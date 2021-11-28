using Company.DataLayer;
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
    public partial class frmAddNewUser : Form
    {
        private bool IsClicked;
        private bool IsClicked2;
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (Unitofworkcus db = new Unitofworkcus())
                {
                    Login user = new Login()
                    {
                        Username = txtUserName.Text,
                        Password = txtPassWord.Text
                    };
                    db.customerRepository.AddUser(user);
                    if (txtPassWord.Text != txtConfirmPassword.Text)
                    {
                        RtlMessageBox.Show("رمز عبور شما و تأیید رمز عبور مطابقت ندارد ، دوباره امتحان کنید", "رمز عبور تایید نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btnShowPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '\0';
            if (IsClicked)
            {
                txtPassWord.PasswordChar = '●';
                IsClicked = false;
            }
            else
            {
                IsClicked = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
            if (IsClicked2)
            {
                txtConfirmPassword.PasswordChar = '●';
                IsClicked2 = false;
            }
            else
            {
                IsClicked2 = true;
            }
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
