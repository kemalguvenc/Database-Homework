using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddPurchase : Form
    {
        public Form_AddPurchase()
        {
            InitializeComponent();

            comboBox_Product.ValueMember = "Ürün Kodu";
            comboBox_Product.DisplayMember = "Ad";
            comboBox_Product.DataSource = Functions.ListView("List-Products");

            comboBox_Supplier.ValueMember = "Tedarikçi Kodu";
            comboBox_Supplier.DisplayMember = "Ad";
            comboBox_Supplier.DataSource = Functions.ListView("List-Suppliers");
        }

        private void button_Purchase_Click(object sender, EventArgs e)
        {
            int product = int.Parse(comboBox_Product.SelectedValue.ToString());
            int unit = Convert.ToInt32(numericUpDown_Unit.Value);
            int supplier = int.Parse(comboBox_Supplier.SelectedValue.ToString());
            DateTime date = DateTime.Today;

            string s_Price = textBox_Price.Text;
            if (Functions.IsEmpty(s_Price, "Toplam ücret boş bırakılamaz!"))
                return;
            if (Functions.IsNumber(s_Price, "Toplam ücret hem sayı hem de sıfırdan büyük olmalıdır!"))
                return;
            int price = int.Parse(s_Price);

            Functions.AddPurchase(product, unit, supplier, date, price);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
