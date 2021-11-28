
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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
         void BindGrid()
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgvEmployees.AutoGenerateColumns = false;
                dgvEmployees.DataSource=db.EmployeeRepository.GetAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgvEmployees.DataSource=db.EmployeeRepository.GetEmployeesByFilter(txtFilter.Text);
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            if(frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.CurrentRow != null)
            {
                int employeeId = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frmAddOrEdit= new frmAddOrEdit();
               frmAddOrEdit.EmployeeId=employeeId;
                if(frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.CurrentRow != null)
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    string name =dgvEmployees.CurrentRow.Cells[1].Value.ToString();
                    if(RtlMessageBox.Show($"آیا از حذف {name} مطمین هستید؟","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        int employeeId = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
                        db.EmployeeRepository.DeleteEmployees(employeeId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
        }

        private void btnPrintInfo_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Nationalid");
            dtPrint.Columns.Add("Employees");
            dtPrint.Columns.Add("phone");
            foreach (DataGridViewRow info in dgvEmployees.Rows)
            {
                dtPrint.Rows.Add(
                    info.Cells[1].Value.ToString(),
                    info.Cells[2].Value.ToString(),
                    info.Cells[3].Value.ToString()                 
                    );
            }
            stiReportinfo.Load(Application.StartupPath + "/ReportEM.mrt");
            stiReportinfo.RegData("DT", dtPrint);
            stiReportinfo.Show();
        }
    }
}
