using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Login : System.Windows.Forms.Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string inputUsername = textBox_Username.Text;
            if (Functions.IsEmpty(inputUsername, "Kullanıcı adı boş bırakılamaz!"))
                return;

            string inputPassword = textBox_Password.Text;
            if (Functions.IsEmpty(inputPassword, "Şifre boş bırakılamaz!"))
                return;

            if (Functions.CheckBranch(inputUsername, inputPassword) == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.");
            }
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
