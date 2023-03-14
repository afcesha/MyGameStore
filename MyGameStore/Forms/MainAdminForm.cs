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
            CurrTable = "Client";
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
            CurrTable = "Product";
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
            CurrTable = "ActivationService";

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
            CurrTable = "DeliveryService";
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
            CurrTable = "Delivery";
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
            CurrTable = "[Order]";
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
            CurrTable = "OrderDetails";
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
            CurrTable = "Supplier";
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            insertClientForm insertClientForm;
            insertClientForm = new insertClientForm();
            insertClientForm.Show();

        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            connection.OpenCon();
            string idClient = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string deleteClient = $"delete from Client where id_Client = {idClient}";
            SqlCommand command2 = new SqlCommand(deleteClient);
            command2.Connection = connection.GetCon();
            command2.ExecuteNonQuery();
        }
        public string id;
        private void updateClient_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateClientForm updateClientForm = new updateClientForm();
            updateClientForm.Show();
            
        }

        private void updateGridView_Click(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            connection.OpenCon();
            string refreshClient = $"Select * from {CurrTable}";
            SqlCommand command1 = new SqlCommand(refreshClient);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (id_textbox.Text.Length == 0)
            {
                connection = new Classes.Connection();
                connection.OpenCon();
                string searchQuery = $"Select * from Client";
                SqlCommand command1 = new SqlCommand(searchQuery);
                command1.Connection = connection.GetCon();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                connection = new Classes.Connection();
                connection.OpenCon();
                string searchQuery = $"Select * from Client where id_Client = {id_textbox.Text}";
                SqlCommand command1 = new SqlCommand(searchQuery);
                command1.Connection = connection.GetCon();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            
        }
    }
}
