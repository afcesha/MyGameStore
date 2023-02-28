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
    public partial class SignUpForm : Form
    {
        Classes.Connection connection;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
            textBoxLogin.MaxLength = 25;
            textBoxPassword.MaxLength = 25;
            textBoxAddress.MaxLength = 200;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            connection.OpenCon();

            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var address = textBoxAddress.Text;
            var phone = textBoxPhone.Text.Replace("-", string.Empty).Replace("(", "7").Replace(") ", string.Empty);
            var birth = textBoxBirth.Text;



            if ((login.Length == 0) || (password.Length == 0) || (address.Length == 0) || (phone.Length == 0) || (birth.Length == 0))
            {
                MessageBox.Show("Заполни все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToDateTime(birth) < Convert.ToDateTime("01.01.1900") || (Convert.ToDateTime(birth) > DateTime.Now))
                {
                    MessageBox.Show("Вы не могли родиться в это время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string usercheckquery = $"Select ClientLogin from Client where ClientLogin = '{login}'";
                    SqlCommand command1 = new SqlCommand(usercheckquery);
                    command1.Connection = connection.GetCon();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show("Такой пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        string signupquery = $"insert Client values ('{login}', '{password}','{address}','{phone}', '{birth}')";
                        SqlCommand command2 = new SqlCommand(signupquery);
                        command2.Connection = connection.GetCon();
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Молодец", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        SignInForm signInForm = new SignInForm();
                        signInForm.Show();
                    }
                }

            }
            connection.CloseCon();
        }
    }
}
