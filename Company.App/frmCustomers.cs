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

namespace Company.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (Unitofworkcus db = new Unitofworkcus())
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمین هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int employeeId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.customerRepository.DeleteCustomers(employeeId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();

        }
        void BindGrid()
        {
           using(Unitofworkcus db = new Unitofworkcus())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.customerRepository.GetAll();
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (Unitofworkcus db = new Unitofworkcus())
            {
                dgvCustomers.DataSource = db.customerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            
            frmAddOrEditCustomers frmAdd =new frmAddOrEditCustomers();
            if(frmAdd.ShowDialog()== DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
               frmAddOrEditCustomers  frmAddOrEdit = new frmAddOrEditCustomers();
                frmAddOrEdit.customerID= customerId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
