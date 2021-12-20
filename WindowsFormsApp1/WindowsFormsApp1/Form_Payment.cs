using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_Payment : Form
    {
        int customerKey;
        public Form_Payment(int customerKey)
        {
            InitializeComponent();
            this.customerKey = customerKey;

            string query = "SELECT \"name\", \"surname\" FROM \"People\" " +
                           "WHERE \"People\".\"key\" = @customerKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text = dataTable.Rows[0].ItemArray[0].ToString();
            textBox_Surname.Text = dataTable.Rows[0].ItemArray[1].ToString();
        }

        private void button_Payment_Click(object sender, EventArgs e)
        {
            string s_payment = textBox_Payment.Text;
            if (Functions.IsEmpty(s_payment, "Ödenecek miktar boş bırakılamaz!"))
                return;
            if (Functions.IsNumber(s_payment, "Ödenecek miktar hem sayı hem de sıfırdan büyük olmalıdır!"))
                return;
            int payment = int.Parse(s_payment);

            if (!Functions.AddPayment(customerKey, payment))
                MessageBox.Show("Ödenen miktar müşterinin borcundan fazla olduğu için ödeme alınamıyor!");

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
