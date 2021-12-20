using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_UpdateProduct : Form
    {
        private int productKey;
        public Form_UpdateProduct(int productKey)
        {
            InitializeComponent();
            this.productKey = productKey;

            string query = "SELECT * FROM \"Products\" WHERE \"key\" = @productKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@productKey", productKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            textBox_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();

            comboBox_Brand.DataSource = Functions.ListView("List-Brands");
            comboBox_Brand.DisplayMember = "name";
            comboBox_Brand.ValueMember = "key";

            comboBox_Type.DataSource = Functions.ListView("List-ProductTypes");
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.ValueMember = "key";

            comboBox_Brand.SelectedValue = int.Parse(dataTable.Rows[0].ItemArray[2].ToString());
            comboBox_Type.SelectedValue = int.Parse(dataTable.Rows[0].ItemArray[3].ToString());
            textBox_UnitPrice.Text = dataTable.Rows[0].ItemArray[4].ToString();
        }

        private void button_AddBrand_Click(object sender, EventArgs e)
        {
            Form_AddBrand form_AddBrand = new Form_AddBrand();
            form_AddBrand.ShowDialog();
        }
        private void button_AddType_Click(object sender, EventArgs e)
        {
            Form_AddProductType form_AddProductType = new Form_AddProductType();
            form_AddProductType.ShowDialog();
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Ürün adı boş bırakılamaz!"))
                return;

            int brand = int.Parse(comboBox_Brand.SelectedValue.ToString());
            int type = int.Parse(comboBox_Type.SelectedValue.ToString());

            string s_unitPrice = textBox_UnitPrice.Text;
            if (Functions.IsEmpty(s_unitPrice, "Ürün birim fiyatı boş bırakılamaz!"))
                return;
            if (Functions.IsNumber(s_unitPrice, "Ürün birim fiyatı hem sayı hem de sıfırdan büyük olmalıdır!"))
                return;
            int unitPrice = int.Parse(s_unitPrice);

            Functions.UpdateProduct(productKey, name, brand, type, unitPrice);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
