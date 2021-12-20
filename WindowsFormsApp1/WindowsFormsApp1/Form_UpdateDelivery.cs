using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form_UpdateDelivery : Form
    {
        private int deliveryKey;
        public Form_UpdateDelivery(int deliveryKey)
        {
            InitializeComponent();
            this.deliveryKey = deliveryKey;

            string query = "SELECT * FROM \"Deliveries\" WHERE \"Deliveries\".\"key\" = @deliveryKey;";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("@deliveryKey", deliveryKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            comboBox_Type.DataSource = Functions.ListView("List-DeliveryTypes");
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.ValueMember = "key";

            comboBox_Situation.DataSource = Functions.ListView("List-SituationTypes");
            comboBox_Situation.DisplayMember = "name";
            comboBox_Situation.ValueMember = "key";

            comboBox_Situation.SelectedValue = int.Parse(dataTable.Rows[0].ItemArray[1].ToString());
            comboBox_Type.SelectedValue = int.Parse(dataTable.Rows[0].ItemArray[2].ToString());
            dateTimePicker_EstimatedDate.Value = DateTime.Parse(dataTable.Rows[0].ItemArray[3].ToString());

            try
            {
                dateTimePicker_HappenedDate.Value = DateTime.Parse(dataTable.Rows[0].ItemArray[4].ToString());
            }
            catch
            {
                dateTimePicker_HappenedDate.Value = DateTime.Today;
                dateTimePicker_HappenedDate.Enabled = false;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int type = int.Parse(comboBox_Type.SelectedValue.ToString());
            int situation = int.Parse(comboBox_Situation.SelectedValue.ToString());
            DateTime estimatedDate = dateTimePicker_EstimatedDate.Value;
            DateTime happenedDate;

            string query = "SELECT \"Sells\".\"date\" " +
                           "FROM \"Sells\" " +
                           "WHERE \"Sells\".\"delivery\" = @deliveryKey";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query);
            npgsqlCommand.Parameters.AddWithValue("deliveryKey", deliveryKey);
            DataTable dataTable = Functions.ListSpecific(npgsqlCommand);

            DateTime shippingDate = DateTime.Parse(dataTable.Rows[0].ItemArray[0].ToString());

            if (dateTimePicker_HappenedDate.Enabled == true)
            {
                happenedDate = dateTimePicker_HappenedDate.Value;
                if (happenedDate >= shippingDate)
                    Functions.UpdateDelivery(deliveryKey, type, situation, estimatedDate, happenedDate);
                else MessageBox.Show("Teslim edildiği tarih sipariş tarihinden önce olduğu için teslimat güncellenemez!");
            }
            else
            {
                Functions.UpdateDelivery(deliveryKey, type, situation, estimatedDate);
            }

            Close();
        }
        private void comboBox_Situation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Situation.SelectedValue.ToString() == "2")
                dateTimePicker_HappenedDate.Enabled = true;
            else
                dateTimePicker_HappenedDate.Enabled = false;
        }
        private void comboBox_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Type.SelectedValue.ToString() == "2")
            {
                comboBox_Situation.SelectedValue = 2;
                comboBox_Situation.Enabled = false;
            }
            else
            {
                comboBox_Situation.Enabled = true;
            }
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
