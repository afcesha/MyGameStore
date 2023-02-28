using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyGameStore.Forms
{
    public partial class MainForm : Form
    {
        Classes.Connection connection;
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            connection.OpenCon();
            string clientquery = $"Select * from Client";
            SqlCommand command1 = new SqlCommand(clientquery);
            command1.Connection = connection.GetCon();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
