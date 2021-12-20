using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_BranchInformation : Form
    {
        public Form_BranchInformation()
        {
            InitializeComponent();
            button_Add.Enabled = false;
            button_Update.Enabled = false;
            RefreshSells();
        }
        private void RefreshSells()
        {
            string query = "SELECT " +
                          "\"Sells\".\"key\" AS \"Satış Kodu\", " +
                          "\"People\".\"name\" AS \"Müşteri Adı\", " +
                          "\"People\".\"surname\" AS \"Müşteri Soyadı\", " +
                          "\"Products\".\"name\" AS \"Satın Alınan Ürün\", " +
                          "\"Sells\".\"unit\" AS \"Ürün Adedi\", " +
                          "\"worker\".\"name\" AS \"Satış Yapan Çalışan Adı\", " +
                          "\"worker\".\"surname\" AS \"Satış Yapan Çalışan Soyadı\", " +
                          "\"Sells\".\"price\" AS \"Toplam Ücret\" " +
                          "FROM \"Sells\" " +
                          "INNER JOIN \"Customers\" ON \"Sells\".\"customer\" = \"Customers\".\"key\" " +
                          "INNER JOIN \"People\" ON \"Customers\".\"key\" = \"People\".\"key\" " +
                          "INNER JOIN \"Products\" ON \"Sells\".\"product\" = \"Products\".\"key\" " +
                          "INNER JOIN \"Workers\" ON \"Sells\".\"worker\" = \"Workers\".\"key\" " +
                          "INNER JOIN \"People\" AS \"worker\" ON \"Workers\".\"key\" = \"worker\".\"key\" " +
                          "WHERE \"Workers\".\"branch\" = @branch " +
                          "ORDER BY \"Sells\".\"date\" DESC;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);
            dataGridView_Sells.DataSource = dataTable;
        }
        private void RefreshPurchases()
        {
            string query = "SELECT " +
                          "\"Purchases\".\"key\" AS \"Alış Kodu\", " +
                          "\"Suppliers\".\"name\" AS \"Tedarikçi\", " +
                          "\"Products\".\"name\" AS \"Ürün\", " +
                          "\"Purchases\".\"unit\" AS \"Ürün Adedi\", " +
                          "\"Purchases\".\"date\" AS \"Alış Tarihi\", " +
                          "\"Purchases\".\"price\" AS \"Toplam Ücret\" " +
                          "FROM \"Purchases\" " +
                          "INNER JOIN \"Suppliers\" ON \"Purchases\".\"supplier\" = \"Suppliers\".\"key\" " +
                          "INNER JOIN \"Products\" ON \"Purchases\".\"product\" = \"Products\".\"key\" " +
                          "WHERE \"Purchases\".\"branch\" = @branch " +
                          "ORDER BY \"Purchases\".\"date\" DESC;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);
            dataGridView_Purchases.DataSource = dataTable;
        }
        private void RefreshSuppliers()
        {
            DataTable dataTable = Functions.ListView("List-Suppliers");
            dataGridView_Suppliers.DataSource = dataTable;
        }
        private void RefreshWorkers()
        {
            string query = "SELECT " +
                          "\"Workers\".\"key\" AS \"Çalışan Kodu\", " +
                          "\"People\".\"name\" AS \"Ad\", " +
                          "\"People\".\"surname\" AS \"Soyad\", " +
                          "\"People\".\"adress\" AS \"Adres\", " +
                          "\"People\".\"phone\" AS \"Telefon Numarası\", " +
                          "\"People\".\"email\" AS \"E-Posta Adresi\", " +
                          "\"Workers\".\"branch\" AS \"Şube\", " +
                          "\"Workers\".\"salary\" AS \"Maaş\", " +
                          "\"Missions\".\"name\" AS \"Görev\", " +
                          "\"Workers\".\"startDate\" AS \"İşe Başlama Tarihi\", " +
                          "\"Workers\".\"finishDate\" AS \"İşten Çıkış Tarihi\" " +
                          "FROM \"Workers\" " +
                          "INNER JOIN \"People\" ON \"Workers\".\"key\" = \"People\".\"key\" " +
                          "INNER JOIN \"Missions\" ON \"Workers\".\"mission\" = \"Missions\".\"key\" " +
                          "WHERE \"Workers\".\"branch\" = @branch " +
                          "ORDER BY \"Workers\".\"finishDate\" DESC, \"Workers\".\"startDate\" DESC;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);
            dataGridView_Workers.DataSource = dataTable;
        }
        private void tabControl_BranchInformation_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                button_Add.Enabled = false;
                button_Update.Enabled = false;
                RefreshSells();
            }

            else if (e.TabPageIndex == 1)
            {
                button_Add.Enabled = true;
                button_Update.Enabled = false;
                RefreshPurchases();
            }

            else if (e.TabPageIndex == 2)
            {
                button_Add.Enabled = true;
                button_Update.Enabled = true;
                RefreshSuppliers();
            }

            else if (e.TabPageIndex == 3)
            {
                button_Add.Enabled = true;
                button_Update.Enabled = true;
                RefreshWorkers();
            }
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            if (tabControl_BranchInformation.SelectedIndex == 0)
            {
                RefreshSells();
            }

            else if (tabControl_BranchInformation.SelectedIndex == 1)
            {
                RefreshPurchases();
            }

            else if (tabControl_BranchInformation.SelectedIndex == 2)
            {
                RefreshSuppliers();
            }

            else if (tabControl_BranchInformation.SelectedIndex == 3)
            {
                RefreshWorkers();
            }
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (tabControl_BranchInformation.SelectedIndex == 1)
            {
                Form_AddPurchase form_AddPurchases = new Form_AddPurchase();
                form_AddPurchases.ShowDialog();
            }
            else if (tabControl_BranchInformation.SelectedIndex == 2)
            {
                Form_AddSupplier form_AddSupplier = new Form_AddSupplier();
                form_AddSupplier.ShowDialog();
            }
            else if (tabControl_BranchInformation.SelectedIndex == 3)
            {
                Form_AddWorker form_AddWorker = new Form_AddWorker();
                form_AddWorker.ShowDialog();
            }
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (tabControl_BranchInformation.SelectedIndex == 0 && dataGridView_Sells.SelectedRows.Count == 1 && dataGridView_Sells.SelectedRows[0].Index != dataGridView_Sells.Rows.Count - 1)
            {
                int sellKey = int.Parse(dataGridView_Sells.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemoveSell(sellKey) == true)
                {
                    MessageBox.Show("Satış başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Sipariş teslim edilmiş ya da müşterinin borcu negatif olacağı için bu satış silinemez!");
                }
            }
            else if (tabControl_BranchInformation.SelectedIndex == 1 && dataGridView_Purchases.SelectedRows.Count == 1 && dataGridView_Purchases.SelectedRows[0].Index != dataGridView_Purchases.Rows.Count - 1)
            {
                int purchaseKey = int.Parse(dataGridView_Purchases.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemovePurchase(purchaseKey) == true)
                {
                    MessageBox.Show("Satış başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Stok miktarının sıfırın altına düşmesine neden olacağı için bu alış silinemiyor!");
                }
            }
            else if (tabControl_BranchInformation.SelectedIndex == 2 && dataGridView_Suppliers.SelectedRows.Count == 1 && dataGridView_Suppliers.SelectedRows[0].Index != dataGridView_Suppliers.Rows.Count - 1)
            {
                int supplierKey = int.Parse(dataGridView_Suppliers.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemoveSupplier(supplierKey) == true)
                {
                    MessageBox.Show("Tedarikçi başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Bu tedarikçiden daha önce ürün alındığı için silinemiyor.");
                }
            }
            else if (tabControl_BranchInformation.SelectedIndex == 3 && dataGridView_Workers.SelectedRows.Count == 1 && dataGridView_Workers.SelectedRows[0].Index != dataGridView_Workers.Rows.Count - 1)
            {
                int workerKey = int.Parse(dataGridView_Workers.SelectedRows[0].Cells[0].Value.ToString());

                if (Functions.RemoveWorker(workerKey) == true)
                {
                    MessageBox.Show("Çalışan başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir nedenden dolayı çalışan silinemedi.");
                }
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (tabControl_BranchInformation.SelectedIndex == 2 && dataGridView_Suppliers.SelectedRows.Count == 1 && dataGridView_Suppliers.SelectedRows[0].Index != dataGridView_Suppliers.Rows.Count - 1)
            {
                int supplierKey = int.Parse(dataGridView_Suppliers.SelectedRows[0].Cells[0].Value.ToString());

                Form_UpdateSupplier form_UpdateSupplier = new Form_UpdateSupplier(supplierKey);
                form_UpdateSupplier.ShowDialog();
            }
            else if (tabControl_BranchInformation.SelectedIndex == 3 && dataGridView_Workers.SelectedRows.Count == 1 && dataGridView_Workers.SelectedRows[0].Index != dataGridView_Workers.Rows.Count - 1)
            {
                int workerKey = int.Parse(dataGridView_Workers.SelectedRows[0].Cells[0].Value.ToString());

                Form_UpdateWorker form_UpdateWorker = new Form_UpdateWorker(workerKey);
                form_UpdateWorker.ShowDialog();
            }
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}