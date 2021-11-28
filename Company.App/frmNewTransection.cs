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
    public partial class frmNewTransection : Form
    {
        private Unitofworkcus db;
        public int accountID = 0;
        public frmNewTransection()
        {
            InitializeComponent();
        }

        private void frmNewTransection_Load(object sender, EventArgs e)
        {

            db = new Unitofworkcus();
            
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.customerRepository.GetNAmeCustomers();
            if (accountID != 0)
            {
                var account = db.TransectionRepository.GetById(accountID);
                txtAmount.Text = account.Amount.ToString();
                txtdescription.Text = account.Description.ToString();
                txtName.Text = db.customerRepository.GetCustomerNameById(account.CustomerID);
                if (account.TypeID == 1)
                {
                    rbRecive.Checked = true;
                }
                else
                {
                    rbRecive.Checked = true;
                }
                this.Text = "ویرایش";
                btnSubmitTransection.Text = "ویرایش";
                db.Dispose();

            }
           
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.customerRepository.GetNAmeCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmitTransection_Click(object sender, EventArgs e)
        {
            if(BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new Unitofworkcus();
                    DataLayer.Transection Transection = new DataLayer.Transection()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerID = db.customerRepository.GetCustomerIdByNAme(txtName.Text),
                        TypeID = (rbRecive.Checked) ? 1 : 2, //conditio if
                        DateTime = DateTime.Now,
                        Description = txtdescription.Text


                    };
                    if (accountID == 0)
                    {
                        db.TransectionRepository.Insert(Transection);
                    }
                    else
                    {
                        Transection.ID = accountID;
                        db.TransectionRepository.Update(Transection);
                    }
                }
                db.Save();
                db.Dispose();
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
            }

        }
    }
    }

