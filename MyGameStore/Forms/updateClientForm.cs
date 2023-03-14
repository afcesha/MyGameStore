using MyGameStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyGameStore.Forms
{
    public partial class updateClientForm : Form
    {
        Classes.Connection connection;
        public updateClientForm()
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
            MainAdminForm mainAdminForm = new MainAdminForm();
            string signupquery = $"update Client set ClientLogin = '{login}', ClientPassword = '{password}', ClientAdress = '{address}', PhoneNumber = '{phone}', BirthDate = '{birth}' where id_Client = '{mainAdminForm.id}'";
            SqlCommand command2 = new SqlCommand(signupquery);
            command2.Connection = connection.GetCon();
            command2.ExecuteNonQuery();
            this.Hide();
        }
    }
}
