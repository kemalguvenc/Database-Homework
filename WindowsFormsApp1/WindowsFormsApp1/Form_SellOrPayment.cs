using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_SellOrPayment : Form
    {
        int customerKey;
        public Form_SellOrPayment(int customerKey)
        {
            InitializeComponent();

            this.customerKey = customerKey;
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            Form_Sell form_Sell = new Form_Sell(customerKey);
            form_Sell.ShowDialog();
            Close();
        }
        private void button_Payment_Click(object sender, EventArgs e)
        {
            Form_Payment form_Payment = new Form_Payment(customerKey);
            form_Payment.ShowDialog();
            Close();
        }
    }
}
