using Accounting.ViewModels.Customers;
using Company.DataLayer;
using Company.Utility;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.App
{
    public partial class frmReoport : Form
    {
        public int TypeID = 0;
        public frmReoport()
        {
            InitializeComponent();
        }

        private void frmReoport_Load(object sender, EventArgs e)
        {
            using (Unitofworkcus db = new Unitofworkcus())
            {
                List<ListCustomerViewModel> lists = new List<ListCustomerViewModel>();
                lists.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                lists.AddRange(db.customerRepository.GetNAmeCustomers());
                cbCustomer.DataSource = lists;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            if(TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";

            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using(Unitofworkcus db = new Unitofworkcus())
            {
                List<DataLayer.Transection> resault = new List<DataLayer.Transection>();
                DateTime? StartDate;
                DateTime? EndDate;

                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    resault.AddRange(db.TransectionRepository.Get(t => t.TypeID == TypeID && t.CustomerID==customerId));
                }
                else
                {
                    resault.AddRange(db.TransectionRepository.Get(t => t.TypeID == TypeID));

                }

                if(txtFromDate.Text != "    /  /")
                {
                    StartDate = Convert.ToDateTime(txtFromDate.Text);
                    StartDate = DateConverter.ToMiladi(StartDate.Value);
                    resault = resault.Where(t => t.DateTime >= StartDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(txtToDate.Text);
                    EndDate = DateConverter.ToMiladi(EndDate.Value);
                    resault = resault.Where(r => r.DateTime <= EndDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                foreach(var res in resault)
                {
                    string Customername = db.customerRepository.GetCustomerNameById(res.CustomerID);
                    dgReport.Rows.Add(res.ID, Customername, res.Amount, res.DateTime.Toshamsi(), res.Description);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnEditTransection_Click(object sender, EventArgs e)
        {
            if(dgReport.CurrentRow != null)
            {
                int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransection frmNew = new frmNewTransection();
                frmNew.accountID = Id;
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            if(dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if(RtlMessageBox.Show("آیا از حذف مطمین هستید؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    using (Unitofworkcus db= new Unitofworkcus())
                    {
                        db.TransectionRepository.Delete(id);
                        db.Save();


                        Filter();
                    }

                }
            }
            
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Customers");
            dtprint.Columns.Add("Amount");
            dtprint.Columns.Add("Date");
            dtprint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtprint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            stiPrintRep.Load(Application.StartupPath + "/Report.mrt");
            stiPrintRep.RegData("DB", dtprint);
            stiPrintRep.Show();


        }
    }
}
