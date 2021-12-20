using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddProductType : Form
    {
        public Form_AddProductType()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Ürün tipi boş bırakılamaz!"))
                return;

            Functions.AddType(name);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
