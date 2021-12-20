using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddWorker : Form
    {
        public Form_AddWorker()
        {
            InitializeComponent();
            DataTable dataTable = Functions.ListView("List-Mission");
            comboBox_Mission.DisplayMember = "name";
            comboBox_Mission.ValueMember = "key";
            comboBox_Mission.DataSource = dataTable;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Çalışanın adı boş bırakılamaz!"))
                return;

            string surname = textBox_Surname.Text;
            if (Functions.IsEmpty(name, "Çalışanın soyadı boş bırakılamaz!"))
                return;

            string adress = textBox_Adress.Text;
            if (Functions.IsEmpty(name, "Çalışanın adresi boş bırakılamaz!"))
                return;

            string phone = textBox_Phone.Text;
            if (Functions.IsEmpty(name, "Çalışanın telefonu boş bırakılamaz!"))
                return;

            string email = textBox_Email.Text;
            if (Functions.IsEmpty(name, "Çalışanın e-posta adresi boş bırakılamaz!"))
                return;

            string s_salary = textBox_Salary.Text;
            if (Functions.IsEmpty(s_salary, "Çalışanın maaşı boş bırakılamaz!"))
                return;
            if (Functions.IsNumber(s_salary, "Çalışanın maaşı hem sayı hem de sıfırdan büyük olmalıdır!"))
                return;
            int salary = int.Parse(s_salary);

            int mission = int.Parse(comboBox_Mission.SelectedValue.ToString());
            DateTime startDate = DateTime.Today;

            Functions.AddWorker(name, surname, adress, phone, email, int.Parse(Functions.BranchKey), salary, mission, startDate);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
