using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddCustomer : Form
    {
        public Form_AddCustomer()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
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

            Functions.AddCustomer(name, surname, adress,phone, email);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
