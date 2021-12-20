using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddSupplier : Form
    {
        public Form_AddSupplier()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name=textBox_Name.Text;
            if (Functions.IsEmpty(name, "Tedarikçinin adı boş bırakılamaz!"))
                return;

            string adress = textBox_Adress.Text;
            if (Functions.IsEmpty(adress, "Tedarikçinin adresi boş bırakılamaz!"))
                return;

            string managerName = textBox_ManagerName.Text;
            if (Functions.IsEmpty(managerName, "Temsilcinin adı boş bırakılamaz!"))
                return;

            string mangerSurname = textBox_ManagerSurname.Text;
            if (Functions.IsEmpty(mangerSurname, "Temsilcinin soyadı boş bırakılamaz!"))
                return;

            string mangerAdress = textBox_ManagerAdress.Text;
            if (Functions.IsEmpty(mangerAdress, "Temsilcinin adresi boş bırakılamaz!"))
                return;

            string managerPhone = textBox_ManagerPhone.Text;
            if (Functions.IsEmpty(managerPhone, "Temsilcinin telefonu boş bırakılamaz!"))
                return;

            string managerEmail = textBox_ManagerEmail.Text;
            if (Functions.IsEmpty(managerEmail, "Temsilcinin e-posta boş bırakılamaz!"))
                return;


            Functions.AddSupplier(name, adress, managerName, mangerSurname, mangerAdress, managerPhone, managerEmail);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
