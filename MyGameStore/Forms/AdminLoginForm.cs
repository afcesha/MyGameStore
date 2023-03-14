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
    public partial class AdminLoginForm : Form
    {

        Classes.Connection connection;
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            textBoxLoginAdm.MaxLength = 25;
            textBoxPasswordAdm.MaxLength = 25;
            textBoxPasswordAdm.PasswordChar = '*';
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            var login = textBoxLoginAdm.Text;
            var password = textBoxPasswordAdm.Text;

            if (login == "admin")
            {
                connection.OpenCon();
                string signinquery = $"Select ClientLogin, ClientPassword from Client where ClientLogin = '{login}' and ClientPassword = '{password}'";
                SqlCommand command1 = new SqlCommand(signinquery);
                command1.Connection = connection.GetCon();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Молодец", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainAdminForm mainAdminForm = new MainAdminForm();
                    this.Hide();
                    mainAdminForm.hellolabel.Text = "Добро пожаловать, " + table.Rows[0][0];
                    mainAdminForm.ShowDialog();

                }
                else
                    MessageBox.Show("Данные введены неправильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.CloseCon();
            }
            else
            {
                MessageBox.Show("Ты не админ, пошел в жопу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
