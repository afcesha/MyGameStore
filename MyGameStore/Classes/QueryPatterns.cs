using MyGameStore.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyGameStore.Classes
{
    
    internal class QueryPatterns
    {
        Classes.Connection connection;

        public void deleteClient()
        {
            connection = new Classes.Connection();
            connection.OpenCon();
            MainAdminForm mainAdminForm = new MainAdminForm();
            string idClient = mainAdminForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string deleteClient = $"delete from Client where id_Client = {idClient} ";
            SqlCommand command2 = new SqlCommand(deleteClient);
            command2.Connection = connection.GetCon();
            command2.ExecuteNonQuery();
        }

        insertClientForm insertClientForm;
        public void insertClient()
        {
            insertClientForm = new insertClientForm();
            insertClientForm.Show();
        }
    }
}
