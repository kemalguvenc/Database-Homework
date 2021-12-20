using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_UpdateSupplier : Form
    {
        int supplierKey;
        int supplierManager;
        public Form_UpdateSupplier(int supplierKey)
        {
            InitializeComponent();
            this.supplierKey = supplierKey;

            string query = "SELECT * FROM \"Suppliers\" " +
                           "INNER JOIN \"SupplierManagers\" ON \"Suppliers\".\"supplierManager\" = \"SupplierManagers\".\"key\" " +
                           "INNER JOIN \"People\" ON \"SupplierManagers\".\"key\" = \"People\".\"key\" " +
                           "WHERE \"Suppliers\".\"key\" = @supplierKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@supplierKey", supplierKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();
            textBox_Adress.Text = dataTable.Rows[0].ItemArray[2].ToString();
            textBox_ManagerName.Text = dataTable.Rows[0].ItemArray[6].ToString();
            textBox_ManagerSurname.Text = dataTable.Rows[0].ItemArray[7].ToString();
            textBox_ManagerAdress.Text = dataTable.Rows[0].ItemArray[8].ToString();
            textBox_ManagerPhone.Text = dataTable.Rows[0].ItemArray[9].ToString();
            textBox_ManagerEmail.Text = dataTable.Rows[0].ItemArray[10].ToString();

            supplierManager = int.Parse(dataTable.Rows[0].ItemArray[3].ToString());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Tedarikçi adı boş bırakılamaz!"))
                return;

            string adress = textBox_Adress.Text;
            if (Functions.IsEmpty(adress, "Tedarikçi adresi boş bırakılamaz!"))
                return;

            string managerName = textBox_ManagerName.Text;
            if (Functions.IsEmpty(managerName, "Temsilci adı boş bırakılamaz!"))
                return;

            string managerSurname = textBox_ManagerSurname.Text;
            if (Functions.IsEmpty(managerSurname, "Temsilci soyadı boş bırakılamaz!"))
                return;

            string managerAdress = textBox_ManagerAdress.Text;
            if (Functions.IsEmpty(managerAdress, "Temsilci adresi boş bırakılamaz!"))
                return;

            string managerPhone = textBox_ManagerPhone.Text;
            if (Functions.IsEmpty(managerPhone, "Temsilci telefonu boş bırakılamaz!"))
                return;

            string managerEmail = textBox_ManagerEmail.Text;
            if (Functions.IsEmpty(managerEmail, "Temsilci e-posta adresi boş bırakılamaz!"))
                return;

            Functions.UpdateSupplier(supplierKey, supplierManager,  name, adress, managerName, managerSurname, managerAdress, managerPhone, managerEmail);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
