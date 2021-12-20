using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddProduct : Form
    {
        public Form_AddProduct()
        {
            InitializeComponent();

            comboBox_Brand.DataSource = Functions.ListView("List-Brands");
            comboBox_Brand.DisplayMember = "name";
            comboBox_Brand.ValueMember = "key";

            comboBox_Type.DataSource = Functions.ListView("List-ProductTypes");
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.ValueMember = "key";
        }
        private void button_Add_Click(object sender, EventArgs e)
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

            Functions.AddProduct(name, brand, type, unitPrice);

            Close();
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
        private void Form_AddProduct_Activated(object sender, EventArgs e)
        {
            comboBox_Brand.DataSource = Functions.ListView("List-Brands");
            comboBox_Brand.DisplayMember = "name";
            comboBox_Brand.ValueMember = "key";

            comboBox_Type.DataSource = Functions.ListView("List-ProductTypes");
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.ValueMember = "key";
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
