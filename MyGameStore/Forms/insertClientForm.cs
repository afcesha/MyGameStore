using MyGameStore.Classes;
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
    public partial class insertClientForm : Form
    {
        Classes.Connection connection;
        public insertClientForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            connection.OpenCon();
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var address = textBoxAddress.Text;
            var phone = textBoxPhone.Text.Replace("-", string.Empty).Replace("(", "7").Replace(") ", string.Empty);
            var birth = textBoxBirth.Text;
            string signupquery = $"insert Client values ('{login}', '{password}','{address}','{phone}', '{birth}')";
            SqlCommand command2 = new SqlCommand(signupquery);
            command2.Connection = connection.GetCon();
            command2.ExecuteNonQuery();
            this.Hide();
        }

        private void insertClientForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
