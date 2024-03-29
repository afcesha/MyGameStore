﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyGameStore.Forms
{
    public partial class WelcomeForm : Form
    {
        Classes.Connection connection;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            connection = new Classes.Connection();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.ShowDialog();
        }
    }
}
