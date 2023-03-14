using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyGameStore.Forms
{
    public partial class MainAdminForm : Form
    {
        Classes.Connection connection;
        public MainAdminForm()
        {
            InitializeComponent();
        }


        public string CurrTable;

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            connection.OpenCon();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            string clientquery = $"Select * from Client";
            SqlCommand command1 = new SqlCommand(clientquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "client";
        }



        private void selectProduct_Click(object sender, EventArgs e)
        {
            string productquery = $"Select * from Product";
            SqlCommand command1 = new SqlCommand(productquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "product";
        }

        private void selectActivationService_Click(object sender, EventArgs e)
        {
            string asquery = $"Select * from ActivationService";
            SqlCommand command1 = new SqlCommand(asquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "as";

        }

        private void selectDeliveryService_Click(object sender, EventArgs e)
        {
            string dsquery = $"Select * from DeliveryService";
            SqlCommand command1 = new SqlCommand(dsquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "ds";
        }

        private void selectDelivery_Click(object sender, EventArgs e)
        {
            string deliveryquery = $"Select * from Delivery";
            SqlCommand command1 = new SqlCommand(deliveryquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "delivery";
        }

        private void selectOrder_Click(object sender, EventArgs e)
        {
            string orderquery = $"Select * from [Order]";
            SqlCommand command1 = new SqlCommand(orderquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "order";
        }

        private void selectOrderDetails_Click(object sender, EventArgs e)
        {
            string odquery = $"Select * from OrderDetails";
            SqlCommand command1 = new SqlCommand(odquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "od";
        }

        private void selectSupplier_Click(object sender, EventArgs e)
        {
            string supplierquery = $"Select * from Supplier";
            SqlCommand command1 = new SqlCommand(supplierquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            CurrTable = "supplier";
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            Classes.QueryPatterns queryPatterns;
            queryPatterns = new Classes.QueryPatterns();
            queryPatterns.insertClient();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            Classes.QueryPatterns queryPatterns;
            queryPatterns = new Classes.QueryPatterns();
            queryPatterns.deleteClient();
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
