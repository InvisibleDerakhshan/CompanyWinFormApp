using Company.DataLayer;
using Company.DataLayer.Context;
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
    public partial class frmAddOrEditCustomers : Form
    {
        public int customerID = 0;
        Unitofworkcus db = new Unitofworkcus();
        public frmAddOrEditCustomers()
        {
            InitializeComponent();
        }

        private void frmAddOrEditCustomers_Load(object sender, EventArgs e)
        {
            if(customerID != 0)
            {
                this.Text = "ویرایش";
                btnSubmit.Text = "ثبت تغییرات";

                var dbCus = db.customerRepository.GetById(customerID);
                txtCustomerName.Text= dbCus.Namee;
                txtEmailCustomer.Text= dbCus.Email ;
                txtPhoneNumber.Text = dbCus.Phone; 
                txtAddress.Text=dbCus.Address;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Customers employees = new Customers()
                {
                Address = txtAddress.Text,
                Namee = txtCustomerName.Text,
                Phone= txtPhoneNumber.Text,
                Email= txtEmailCustomer.Text
                };
                if (customerID == 0)
                {
                    db.customerRepository.InsertCustomers(employees);
                }
                else
                {
                    employees.CustomerID = customerID;
                    db.customerRepository.UpdateCustomers(employees);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
