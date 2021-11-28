﻿using Company.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Company.App
{
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public bool IsADD = false;
        private bool IsClicked = false;
        public static string username;
        public static string password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnlogin.Text = "ذخیره تغییرات";
                txtPassword.PasswordChar = '\0';
                btnShowPassWord.Visible = false;
                using(Unitofworkcus db = new Unitofworkcus())
                {
                   
                    var login = db.LoginRepository.Get().FirstOrDefault(l => l.Username == username && l.Password == password);
                    txtPassword.Text = login.Password;
                    txtUserName.Text = login.Username;

                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (Unitofworkcus db = new Unitofworkcus())
                {
                   
                    username = txtUserName.Text;
                    password = txtPassword.Text;
                    if (IsEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.Username = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.Username == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام کاربری یا کلمه عبور معتبر نیست");
                        }
                    }
                }
            }
        }

        private void btnShowPassWord_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            if (IsClicked)
            {
                txtPassword.PasswordChar = '●';
                IsClicked = false;
            }
            else
            {
                IsClicked = true;
            }
        }
    }
}