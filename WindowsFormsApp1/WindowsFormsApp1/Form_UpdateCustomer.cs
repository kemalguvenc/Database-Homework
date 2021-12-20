using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_UpdateCustomer : Form
    {
        private int customerKey;
        public Form_UpdateCustomer(int customerKey)
        {
            InitializeComponent();
            this.customerKey = customerKey;

            string query = "SELECT * FROM \"People\" WHERE \"key\" = @customerKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();
            textBox_Surname.Text = dataTable.Rows[0].ItemArray[2].ToString();
            textBox_Adress.Text = dataTable.Rows[0].ItemArray[3].ToString();
            textBox_Phone.Text = dataTable.Rows[0].ItemArray[4].ToString();
            textBox_Email.Text = dataTable.Rows[0].ItemArray[5].ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Müşteri adı boş bırakılamaz!"))
                return;

            string surname = textBox_Surname.Text;
            if (Functions.IsEmpty(surname, "Müşteri soyadı boş bırakılamaz!"))
                return;

            string adress = textBox_Adress.Text;
            if (Functions.IsEmpty(adress, "Müşteri adresi boş bırakılamaz!"))
                return;

            string phone = textBox_Phone.Text;
            if (Functions.IsEmpty(phone, "Müşteri telefonu boş bırakılamaz!"))
                return;

            string email = textBox_Email.Text;
            if (Functions.IsEmpty(phone, "Müşteri e-posta adresi boş bırakılamaz!"))
                return;

            Functions.UpdateCustomer(customerKey, name, surname, adress, phone, email);
            
            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
