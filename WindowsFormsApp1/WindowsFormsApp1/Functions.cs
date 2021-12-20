using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    static class Functions
    {
        static NpgsqlConnection npgsqlConnection = new NpgsqlConnection("server=localhost; port=5432; Database=MainDatabase; user Id=postgres; password=123456");
        static public string BranchKey = "-1";
        static public DataTable ListView(string view)
        {
            npgsqlConnection.Open();

            string query = "Select * FROM ";
            query = query + "\"" + view + "\"";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            return dataTable;
        }
        static public DataTable ListSpecific(string query)
        {
            npgsqlConnection.Open();

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            return dataTable;
        }
        static public DataTable ListSpecific(NpgsqlCommand npgsqlCommand)
        {
            npgsqlConnection.Open();

            npgsqlCommand.Connection = npgsqlConnection;
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            return dataTable;
        }
        static public bool IsEmpty(string expression, string warning)
        {
            if (expression.Trim() == "")
            {
                MessageBox.Show(warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool IsNumber(string expression, string warning)
        {
            if (!expression.All(char.IsNumber))
            {
                MessageBox.Show(warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool CheckBranch(string username, string password)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"CheckBranch\"(@usernameInput,@passwordInput);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@usernameInput", username);
            npgsqlCommand.Parameters.AddWithValue("@passwordInput", password);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() != "-1")
            {
                BranchKey = dataTable.Rows[0].ItemArray[0].ToString();
                return true;
            }
            else return false;
        }
        static public void AddPerson(string name, string surname, string adress, string phone, string email)
        {
            npgsqlConnection.Open();

            string query = "Insert Into \"People\"" +
                           "(\"name\", \"surname\", \"adress\", \"phone\", \"email\")" +
                           "values(@name, @surname, @adress, @phone, @email);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@surname", surname);
            npgsqlCommand.Parameters.AddWithValue("@adress", adress);
            npgsqlCommand.Parameters.AddWithValue("@phone", phone);
            npgsqlCommand.Parameters.AddWithValue("@email", email);
            npgsqlCommand.ExecuteNonQuery();
        }
        static public void AddBrand(string name)
        {
            npgsqlConnection.Open();

            string query = "Insert Into \"Brands\"" +
                           "(\"name\")" +
                           "values(@name);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddType(string name)
        {
            npgsqlConnection.Open();

            string query = "Insert Into \"ProductTypes\"" +
                           "(\"name\")" +
                           "values(@name);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddSupplierManager(string name, string surname, string adress, string phone, string email)
        {
            AddPerson(name, surname, adress, phone, email);

            string query = "INSERT INTO \"SupplierManagers\"" +
                           "(\"key\")" +
                           "Values (currval('\"People_key_seq\"'));";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.ExecuteNonQuery();
        }
        static public void AddCustomer(string name, string surname, string adress, string phone, string email)
        {
            AddPerson(name, surname, adress, phone, email);

            string query = "INSERT INTO \"Customers\"" +
                           "(\"key\", \"debt\")" +
                           "Values (currval('\"People_key_seq\"'),'0');";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddProduct(string name, int brand, int type, int unitPrice)
        {
            npgsqlConnection.Open();

            string query = "Insert Into \"Products\"" +
                           "(\"name\", \"brand\", \"type\", \"unitPrice\")" +
                           "values(@name, @brand, @type, @unitPrice);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@brand", brand);
            npgsqlCommand.Parameters.AddWithValue("@type", type);
            npgsqlCommand.Parameters.AddWithValue("@unitPrice", unitPrice);

            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddSupplier(string name, string adress, string managerName, string managerSurname, string managerAdress, string managerPhone, string managerEmail)
        {
            AddSupplierManager(managerName, managerSurname, managerAdress, managerPhone, managerEmail);

            string query = "Insert Into \"Suppliers\"" +
                           "(\"name\", \"adress\", \"supplierManager\")" +
                           "Values(@name, @adress, currval('\"People_key_seq\"'));";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@adress", adress);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddPurchase(int product, int unit, int supplier, DateTime date, int price)
        {
            npgsqlConnection.Open();

            string query = "Insert Into \"Purchases\"" +
                           "(\"supplier\", \"date\", \"product\", \"branch\", \"unit\", \"price\")" +
                           "values(@supplier, @date, @product, @branch, @unit, @price);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@supplier", supplier);
            npgsqlCommand.Parameters.AddWithValue("@date", date);
            npgsqlCommand.Parameters.AddWithValue("@product", product);
            npgsqlCommand.Parameters.AddWithValue("@branch", int.Parse(Functions.BranchKey));
            npgsqlCommand.Parameters.AddWithValue("@unit", unit);
            npgsqlCommand.Parameters.AddWithValue("@price", price);

            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddWorker(string name, string surname, string adress, string phone, string email, int branch, int salary, int mission, DateTime startDate)
        {
            AddPerson(name, surname, adress, phone, email);

            string query = "Insert Into \"Workers\"" +
                           "(\"key\", \"branch\", \"salary\", \"mission\", \"startDate\", \"finishDate\")" +
                           "values(currval('\"People_key_seq\"'),@branch, @salary, @mission, @start, NULL);";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

            npgsqlCommand.Parameters.AddWithValue("@branch", branch);
            npgsqlCommand.Parameters.AddWithValue("@salary", salary);
            npgsqlCommand.Parameters.AddWithValue("@mission", mission);
            npgsqlCommand.Parameters.AddWithValue("@start", startDate);

            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void AddDelivery(int type, int situation, DateTime estimatedDate)
        {
            npgsqlConnection.Open();

            string query = "INSERT INTO \"Deliveries\" " +
                            "(\"type\", \"situation\", \"estimatedDate\") " +
                            "VALUES (@type, @situation, @estimatedDate);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@type", type);
            npgsqlCommand.Parameters.AddWithValue("@situation", situation);
            npgsqlCommand.Parameters.AddWithValue("@estimatedDate", estimatedDate);

            npgsqlCommand.ExecuteNonQuery();
        }
        static public void AddSell(int customer, DateTime date, int product, int unit, int worker, int price, int type, int situation, DateTime estimatedDate)
        {
            AddDelivery(type, situation, estimatedDate);

            string query = "INSERT INTO \"Sells\" " +
                            "(\"customer\", \"date\", \"product\", \"unit\", \"worker\", \"delivery\", \"price\") " +
                            "VALUES (@customer, @date, @product, @unit, @worker, currval('\"Deliveries_key_seq\"'), @price);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@customer", customer);
            npgsqlCommand.Parameters.AddWithValue("@date", date);
            npgsqlCommand.Parameters.AddWithValue("@product", product);
            npgsqlCommand.Parameters.AddWithValue("@unit", unit);
            npgsqlCommand.Parameters.AddWithValue("@worker", worker);
            npgsqlCommand.Parameters.AddWithValue("@price", price);

            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public bool AddPayment(int customerKey, int payment)
        {
            string query = "SELECT \"debt\" " +
                           "FROM \"Customers\" " +
                           "WHERE \"Customers\".\"key\" = @customerKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);

            DataTable dataTable = ListSpecific(npgsqlCommand);

            int debt = int.Parse(dataTable.Rows[0].ItemArray[0].ToString());

            if (payment > debt)
                return false;

            npgsqlConnection.Open();

            query = "INSERT INTO \"Payments\" " +
                    "(\"customer\", \"payment\") " +
                    "VALUES (@customerKey, @payment);";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);
            npgsqlCommand.Parameters.AddWithValue("@payment", payment);

            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();

            return true;
        }
        static public bool RemoveCustomer(int customerKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemoveCustomer\"(@customerKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@customerKey", customerKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool RemoveProduct(int productKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemoveProduct\"(@productKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@productKey", productKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool RemoveSell(int SellKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemoveSell\"(@SellKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@SellKey", SellKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            try
            {
                npgsqlDataAdapter.Fill(dataTable);
            }
            catch
            {
                npgsqlConnection.Close();
                return false;
            }

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool RemovePurchase(int purchaseKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemovePurchase\"(@purchaseKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@purchaseKey", purchaseKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool RemoveSupplier(int supplierKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemoveSupplier\"(@supplierKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@supplierKey", supplierKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool RemoveWorker(int workerKey)
        {
            npgsqlConnection.Open();

            string query = "SELECT \"RemoveWorker\"(@workerKey);";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@workerKey", workerKey);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            npgsqlConnection.Close();

            if (dataTable.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public void UpdatePerson(int personKey, string name, string surname, string adress, string phone, string email)
        {
            npgsqlConnection.Open();

            string query = "UPDATE \"People\" " +
                           "SET " +
                           "\"name\" = @name, " +
                           "\"surname\" = @surname, " +
                           "\"adress\" = @adress, " +
                           "\"phone\" = @phone, " +
                           "\"email\" = @email " +
                           "WHERE \"key\" = @personKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@surname", surname);
            npgsqlCommand.Parameters.AddWithValue("@adress", adress);
            npgsqlCommand.Parameters.AddWithValue("@phone", phone);
            npgsqlCommand.Parameters.AddWithValue("@email", email);
            npgsqlCommand.Parameters.AddWithValue("@personKey", personKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void UpdateCustomer(int customerKey, string name, string surname, string adress, string phone, string email)
        {
            UpdatePerson(customerKey, name, surname, adress, phone, email);
        }
        static public void UpdateProduct(int productKey, string name, int brand, int type, int unitPrice)
        {
            npgsqlConnection.Open();

            string query = "UPDATE \"Products\" " +
                           "SET " +
                           "\"name\" = @name, " +
                           "\"brand\" = @brand, " +
                           "\"type\" = @type " +
                           "WHERE \"key\" = @productKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@brand", brand);
            npgsqlCommand.Parameters.AddWithValue("@type", type);
            npgsqlCommand.Parameters.AddWithValue("@productKey", productKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void UpdateDelivery(int deliveryKey, int type, int situation, DateTime estimatedDate, DateTime happenedDate)
        {
            npgsqlConnection.Open();

            string query = "UPDATE \"Deliveries\" " +
                           "SET " +
                           "\"type\" = @type, " +
                           "\"situation\" = @situation, " +
                           "\"estimatedDate\" = @estimatedDate, " +
                           "\"happenedDate\" = @happenedDate " +
                           "WHERE \"key\" = @deliveryKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@type", type);
            npgsqlCommand.Parameters.AddWithValue("@situation", situation);
            npgsqlCommand.Parameters.AddWithValue("@estimatedDate", estimatedDate);
            npgsqlCommand.Parameters.AddWithValue("@happenedDate", happenedDate);
            npgsqlCommand.Parameters.AddWithValue("@deliveryKey", deliveryKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void UpdateDelivery(int deliveryKey, int type, int situation, DateTime estimatedDate)
        {
            npgsqlConnection.Open();

            string query = "UPDATE \"Deliveries\" " +
                           "SET " +
                           "\"type\" = @type, " +
                           "\"situation\" = @situation, " +
                           "\"estimatedDate\" = @estimatedDate " +
                           "WHERE \"key\" = @deliveryKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@type", type);
            npgsqlCommand.Parameters.AddWithValue("@situation", situation);
            npgsqlCommand.Parameters.AddWithValue("@estimatedDate", estimatedDate);
            npgsqlCommand.Parameters.AddWithValue("@deliveryKey", deliveryKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void UpdateSupplier(int supplierKey, int supplierManager, string name, string adress, string managerName, string managerSurname, string managerAdress, string managerPhone, string managerEmail)
        {
            UpdatePerson(supplierManager, managerName, managerSurname, managerAdress, managerPhone, managerEmail);
            
            npgsqlConnection.Open();

            string query = "UPDATE \"Suppliers\" " +
                           "SET " +
                           "\"name\" = @name, " +
                           "\"adress\" = @adress " +
                           "WHERE \"key\" = @supplierKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@name", name);
            npgsqlCommand.Parameters.AddWithValue("@adress", adress);
            npgsqlCommand.Parameters.AddWithValue("@supplierKey", supplierKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
        static public void UpdateWorker(int workerKey, string name, string surname, string adress, string phone, string email, int salary, int mission, DateTime startDate)
        {
            UpdatePerson(workerKey, name, surname, adress, phone, email);

            npgsqlConnection.Open();

            string query = "UPDATE \"Workers\" " +
                           "SET " +
                           "\"salary\" = @salary, " +
                           "\"mission\" = @mission, " +
                           "\"startDate\" = @startDate " +
                           "WHERE \"key\" = @workerKey;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@salary", salary);
            npgsqlCommand.Parameters.AddWithValue("@mission", mission);
            npgsqlCommand.Parameters.AddWithValue("@startDate", startDate);
            npgsqlCommand.Parameters.AddWithValue("@workerKey", workerKey);
            npgsqlCommand.ExecuteNonQuery();

            npgsqlConnection.Close();
        }
    }
}