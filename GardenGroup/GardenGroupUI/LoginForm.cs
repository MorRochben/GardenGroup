﻿using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupLogic;
using GardenGroupModel;
using System.Web;

namespace GardenGroupUI
{
    public partial class LoginForm : Form
    {
        UserService userService = new UserService();
        List<User> users;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            RememberCredentials();

            users = userService.GetAll();
            int index = users.FindIndex(user => user.Email == tb_Username.Text);

            // Q: Probably this should be in the try catch clause?
            if (tb_Username.Text == null || tb_Password.Text == null)
            {
                MessageBox.Show("Please enter a username and password.");
            }
            else if (index >= 0)
            {
                // TO DO: Show screens depending on the type of user  
                if (users[index].Password == tb_Password.Text)
                {
                    DialogResult result = MessageBox.Show("Login Successfull", "Sucessfully logged in!",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if(result == DialogResult.OK)
                    {
                        this.Hide();
                        Form1 mainform = new Form1();
                        mainform.Closed += (s, args) => this.Close();
                        mainform.ShowDialog();

                    }
                }
            }
            else
            {
                MessageBox.Show("Login unsuccessfull", "Can't login! Incorrect credentials! ",
                       MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                tb_Username.Text = Properties.Settings.Default.UserName;
                tb_Password.Text = Properties.Settings.Default.Password;
            }
        }

        private void RememberCredentials()
        {
            if(cb_RemeberMe.Checked)
            {
                Properties.Settings.Default.UserName = tb_Username.Text;
                Properties.Settings.Default.Password = tb_Password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
