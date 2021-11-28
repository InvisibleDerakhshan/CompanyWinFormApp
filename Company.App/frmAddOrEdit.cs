using Company.DataLayer;
using Company.DataLayer.Context;
using Company.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Company.App
{
    public partial class frmAddOrEdit : Form
    {
        public int EmployeeId = 0;
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
           
            if (EmployeeId != 0)
            {
                this.Text = "ویرایش مشخصات";
                btnSave.Text = "ویرایش";
                var employee= db.EmployeeRepository.GetById(EmployeeId);
                txtName.Text = employee.FullName;
                txtNationalId.Text = employee.NationalID;
                txtEmail.Text = employee.Email;
                //txtBirthDay.Text = employee.BirthDay;
                txtPhonenumber.Text=employee.Phone;
                pcEmployee.ImageLocation = Application.StartupPath + "/Images/" + employee.imagee;

            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcEmployee.ImageLocation = openFile.FileName;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (BaseValidator.IsFormValid(this.components))
            {

                string IMGName = Guid.NewGuid().ToString() + Path.GetExtension(pcEmployee.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcEmployee.Image.Save(path + IMGName);
                Employees employees = new Employees()
                {
                    Address = txtAddress.Text,
                    NationalID = txtNationalId.Text,
                    FullName = txtName.Text,
                    Phone = txtPhonenumber.Text,
                    Email = txtEmail.Text,
              
                    imagee = IMGName

                };

                if (EmployeeId == 0)
                {
                    db.EmployeeRepository.InsertEmployees(employees);
                }
                else
                {
                    employees.CustomerID= EmployeeId;
                    db.EmployeeRepository.UpdateEmployees(employees);
                }
                db.Save();
                DialogResult = DialogResult.OK;

            }
        }
    }
}
