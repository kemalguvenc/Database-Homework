using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_System : Form
    {
        public Form_System()
        {
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            if (Functions.BranchKey == "-1")
            {
                Close();
            }
            InitializeComponent();

            RefreshCustomers();
        }

        private void RefreshCustomers()
        {
            DataTable dataTable = Functions.ListView("List-Customers");
            dataGridView_Customers.DataSource = dataTable;
        }
        private void RefreshProducts()
        {
            string query = "SELECT " +
                          "\"Products\".key AS \"Ürün Kodu\", " +
                          "\"Products\".name AS \"Ad\", " +
                          "\"Products\".\"unitPrice\" AS \"Birim Fiyat\", " +
                          "\"Brands\".name AS \"Marka\", " +
                          "\"ProductTypes\".name AS \"Tip\", " +
                          "\"StocksOfBranches\".stock AS \"Stok\" " +
                          "FROM \"Products\" " +
                          "INNER JOIN \"Brands\" ON \"Products\".brand = \"Brands\".key " +
                          "INNER JOIN \"ProductTypes\" ON \"Products\".type = \"ProductTypes\".key " +
                          "INNER JOIN \"StocksOfBranches\" ON \"StocksOfBranches\".product = \"Products\".key " +
                          "WHERE \"StocksOfBranches\".\"branch\" = @branch " +
                          "ORDER BY \"Products\".name;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);
            dataGridView_Products.DataSource = dataTable;
        }
        private void RefreshDeliveries()
        {
            string query = "SELECT " +
                          "\"Deliveries\".\"key\" AS \"Teslimat Kodu\", " +
                          "\"Customers\".\"key\" AS \"Müşteri Kodu\", " +
                          "\"People\".\"name\" AS \"Müşteri Adı\", " +
                          "\"People\".\"surname\" AS \"Müşteri Soyadı\", " +
                          "\"People\".\"adress\" AS \"Müşteri Adresi\", " +
                          "\"Products\".\"name\" AS \"Ürün Adı\", " +
                          "\"Sells\".\"unit\" AS \"Ürün Adedi\", " +
                          "\"Sells\".\"date\" AS \"Sipariş Tarihi\", " +
                          "\"Deliveries\".\"estimatedDate\" AS \"Tahmini Teslimat Tarihi\", " +
                          "\"Deliveries\".\"happenedDate\" AS \"Gerçekleşen Teslimat Tarihi\", " +
                          "\"DeliveryTypes\".\"name\" AS \"Teslimat Şekli\", " +
                          "\"SituationTypes\".\"name\" AS \"Teslimat Durumu\" " +
                          "FROM \"Deliveries\" " +
                          "INNER JOIN \"DeliveryTypes\" ON \"Deliveries\".\"type\" = \"DeliveryTypes\".\"key\" " +
                          "INNER JOIN \"SituationTypes\" ON \"Deliveries\".\"situation\" = \"SituationTypes\".\"key\" " +
                          "INNER JOIN \"Sells\" ON \"Sells\".\"delivery\" = \"Deliveries\".\"key\" " +
                          "INNER JOIN \"Products\" ON \"Sells\".\"product\" = \"Products\".\"key\" " +
                          "INNER JOIN \"Customers\" ON \"Sells\".\"customer\" = \"Customers\".\"key\" " +
                          "INNER JOIN \"People\" ON \"Customers\".\"key\" = \"People\".\"key\" " +
                          "INNER JOIN \"Workers\" ON \"Sells\".\"worker\" = \"Workers\".\"key\" " +
                          "WHERE \"Workers\".\"branch\" = @branch " +
                          "ORDER BY \"Sells\".date DESC;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);
            dataGridView_Deliveries.DataSource = dataTable;
        }
        private void tabControl_System_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                button_Add.Enabled = true;
                button_Remove.Enabled = true;
                RefreshCustomers();
            }
            else if (e.TabPageIndex == 1)
            {
                button_Add.Enabled = true;
                button_Remove.Enabled = true;
                RefreshProducts();
            }
            else if (e.TabPageIndex == 2)
            {
                button_Add.Enabled = false;
                button_Remove.Enabled = false;
                RefreshDeliveries();
            }
        }
        private void dataGridView_Customers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_Customers.SelectedRows.Count == 1 && dataGridView_Customers.SelectedRows[0].Index != dataGridView_Customers.Rows.Count - 1)
            {
                int customerKey = int.Parse(dataGridView_Customers.SelectedRows[0].Cells[0].Value.ToString());
                Form_SellOrPayment form_SellOrPayment = new Form_SellOrPayment(customerKey);
                form_SellOrPayment.ShowDialog();
            }
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            if (tabControl_System.SelectedIndex == 0)
            {
                RefreshCustomers();
            }
            else if (tabControl_System.SelectedIndex == 1)
            {
                RefreshProducts();
            }
            else if (tabControl_System.SelectedIndex == 2)
            {
                RefreshDeliveries();
            }
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (tabControl_System.SelectedIndex == 0)
            {
                Form_AddCustomer form_AddCustomer = new Form_AddCustomer();
                form_AddCustomer.ShowDialog();
            }
            else if (tabControl_System.SelectedIndex == 1)
            {
                Form_AddProduct form_AddProduct = new Form_AddProduct();
                form_AddProduct.ShowDialog();
            }
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (tabControl_System.SelectedIndex == 0 && dataGridView_Customers.SelectedRows.Count == 1 && dataGridView_Customers.SelectedRows[0].Index != dataGridView_Customers.Rows.Count - 1)
            {
                int customerKey = int.Parse(dataGridView_Customers.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemoveCustomer(customerKey) == true)
                {
                    MessageBox.Show("Müşteri başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Müşteri daha önce alışveriş yaptığı için silinemiyor.");
                }
            }
            else if (tabControl_System.SelectedIndex == 1 && dataGridView_Products.SelectedRows.Count == 1 && dataGridView_Products.SelectedRows[0].Index != dataGridView_Products.Rows.Count - 1)
            {
                int productKey = int.Parse(dataGridView_Products.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemoveProduct(productKey) == true)
                {
                    MessageBox.Show("Ürün başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Bu ürün daha önceden alındığı için silinemiyor.");
                }
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (tabControl_System.SelectedIndex == 0 && dataGridView_Customers.SelectedRows.Count==1 && dataGridView_Customers.SelectedRows[0].Index != dataGridView_Customers.Rows.Count - 1)
            {
                int customerKey = int.Parse(dataGridView_Customers.SelectedRows[0].Cells[0].Value.ToString());

                Form_UpdateCustomer form_UpdateCustomer = new Form_UpdateCustomer(customerKey);
                form_UpdateCustomer.ShowDialog();
            }
            else if (tabControl_System.SelectedIndex == 1 && dataGridView_Products.SelectedRows.Count == 1 && dataGridView_Products.SelectedRows[0].Index != dataGridView_Products.Rows.Count - 1)
            {
                int productKey = int.Parse(dataGridView_Products.SelectedRows[0].Cells[0].Value.ToString());

                Form_UpdateProduct form_UpdateProduct = new Form_UpdateProduct(productKey);
                form_UpdateProduct.ShowDialog();
            }
            else if (tabControl_System.SelectedIndex == 2 && dataGridView_Deliveries.SelectedRows.Count == 1 && dataGridView_Deliveries.SelectedRows[0].Index != dataGridView_Deliveries.Rows.Count - 1)
            {
                int deliveryKey = int.Parse(dataGridView_Deliveries.SelectedRows[0].Cells[0].Value.ToString());
                Form_UpdateDelivery form_UpdateDelivery = new Form_UpdateDelivery(deliveryKey);
                form_UpdateDelivery.ShowDialog();
            }
        }
        private void button_BranchInformation_Click(object sender, EventArgs e)
        {
            Form_BranchInformation form_BranchInformation = new Form_BranchInformation();
            form_BranchInformation.ShowDialog();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
