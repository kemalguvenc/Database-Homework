using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_AddBrand : Form
    {
        public Form_AddBrand()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (Functions.IsEmpty(name, "Marka adı boş bırakılamaz!"))
                return;

            Functions.AddBrand(name);

            Close();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
