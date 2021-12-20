using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_Sell : Form
    {
        int customerKey;
        public Form_Sell(int customerKey)
        {
            InitializeComponent();
            this.customerKey = customerKey;

            string query = "SELECT * FROM \"People\" WHERE \"key\" = @customerKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text=dataTable.Rows[0].ItemArray[1].ToString();
            textBox_Surname.Text = dataTable.Rows[0].ItemArray[2].ToString();
            textBox_Adress.Text = dataTable.Rows[0].ItemArray[3].ToString();

            textBox_UnitPrice.Text = 0.ToString("C", CultureInfo.CurrentCulture);

            comboBox_Product.ValueMember = "Ürün Kodu";
            comboBox_Product.DisplayMember = "Ad";
            comboBox_Product.DataSource = Functions.ListView("List-Products");

            comboBox_Type.ValueMember = "key";
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.DataSource = Functions.ListView("List-DeliveryTypes");

            comboBox_Worker.ValueMember = "Çalışan Kodu";
            comboBox_Worker.DisplayMember = "Ad";
            comboBox_Worker.DataSource = Functions.ListView("List-Workers");

            query = "SELECT " +
                          "\"Workers\".\"key\" AS \"Çalışan Kodu\", " +
                          "\"People\".\"name\" AS \"Ad\" " +
                          "FROM \"Workers\" " +
                          "INNER JOIN \"People\" ON \"Workers\".\"key\" = \"People\".\"key\" " +
                          "WHERE \"Workers\".\"branch\" = @branch AND " +
                          "\"Workers\".\"finishDate\" IS NULL;";

            npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            dataTable = Functions.ListSpecific(npgsqlCommand);
            comboBox_Worker.ValueMember = "Çalışan Kodu";
            comboBox_Worker.DisplayMember = "Ad";
            comboBox_Worker.DataSource = dataTable;

            textBox_Total.Text = 0.ToString("C", CultureInfo.CurrentCulture);
            button_Sell.Enabled = false;
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int product = int.Parse(comboBox_Product.SelectedValue.ToString());
            int unit = Convert.ToInt32(numericUpDown_Unit.Value);
            int worker = int.Parse(comboBox_Worker.SelectedValue.ToString());
            int price = Convert.ToInt32(decimal.Parse(textBox_Total.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number));
            int type = int.Parse(comboBox_Type.SelectedValue.ToString());
            int situation;
            if (type == 2)
                situation = 2;
            else situation = 1;
            DateTime estimatedDate = DateTime.Now.AddDays(7);

            Functions.AddSell(customerKey, date, product, unit, worker, price, type, situation, estimatedDate);

            Close();
        }
        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productKey = int.Parse(comboBox_Product.SelectedValue.ToString());

            string query = "SELECT \"unitPrice\" FROM \"Products\" " +
                    "WHERE \"key\"= '" + productKey + "'; ";
            DataTable dataTable = Functions.ListSpecific(query);
            textBox_UnitPrice.Text = double.Parse(dataTable.Rows[0].ItemArray[0].ToString()).ToString("C", CultureInfo.CurrentCulture);

            query = "SELECT \"stock\" FROM \"StocksOfBranches\" " +
                           "WHERE \"product\"= '" + productKey + "' AND " +
                           "\"branch\"= '" + Functions.BranchKey + "';";
            dataTable = Functions.ListSpecific(query);
            textBox_Stock.Text = dataTable.Rows[0].ItemArray[0].ToString();

            numericUpDown_Unit.Maximum = int.Parse(textBox_Stock.Text);
            numericUpDown_Unit.Value = numericUpDown_Unit.Value;
        }
        private void numericUpDown_Unit_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown_Unit.Value == 0)
            {
                button_Sell.Enabled = false;
            }
            else
            {
                button_Sell.Enabled = true;
            }
            textBox_Total.Text = (decimal.Parse(textBox_UnitPrice.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number) * numericUpDown_Unit.Value).ToString("C", CultureInfo.CurrentCulture);
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
