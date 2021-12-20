using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_UpdateWorker : Form
    {
        int workerKey;
        public Form_UpdateWorker(int workerKey)
        {
            InitializeComponent();
            this.workerKey = workerKey;

            DataTable dataTable = Functions.ListView("List-Mission");
            comboBox_Mission.DisplayMember = "name";
            comboBox_Mission.ValueMember = "key";
            comboBox_Mission.DataSource = dataTable;

            string query = "SELECT * FROM \"Workers\" " +
                           "INNER JOIN \"Missions\" ON \"Workers\".\"mission\" = \"Missions\".\"key\" " +
                           "INNER JOIN \"People\" ON \"Workers\".\"key\" = \"People\".\"key\" " +
                           "WHERE \"Workers\".\"key\" = @workerKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@workerKey", workerKey);
            dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text = dataTable.Rows[0].ItemArray[9].ToString();
            textBox_Surname.Text = dataTable.Rows[0].ItemArray[10].ToString();
            textBox_Adress.Text = dataTable.Rows[0].ItemArray[11].ToString();
            textBox_Phone.Text = dataTable.Rows[0].ItemArray[12].ToString();
            textBox_Email.Text = dataTable.Rows[0].ItemArray[13].ToString();
            textBox_Salary.Text = dataTable.Rows[0].ItemArray[2].ToString();
            comboBox_Mission.SelectedValue = dataTable.Rows[0].ItemArray[3].ToString();
            dateTimePicker_StartDate.Value = DateTime.Parse(dataTable.Rows[0].ItemArray[4].ToString());
        }

        private void button_Update_Click(object sender, EventArgs e)
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
            DateTime startDate = dateTimePicker_StartDate.Value;

            Functions.UpdateWorker(workerKey, name, surname, adress, phone, email, salary, mission, startDate);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
