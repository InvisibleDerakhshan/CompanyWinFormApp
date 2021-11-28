
namespace Company.App
{
    partial class frmEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnEditEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintInfo = new System.Windows.Forms.ToolStripButton();
            this.stiReportinfo = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewEmployee,
            this.btnEditEmployee,
            this.btnRemoveEmployee,
            this.btnRefresh,
            this.btnPrintInfo,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Image = global::Company.App.Properties.Resources.icons8_add_user_male_50;
            this.btnNewEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(67, 69);
            this.btnNewEmployee.Text = "کارمند جدید";
            this.btnNewEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Image = global::Company.App.Properties.Resources.icons8_registration_50;
            this.btnEditEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(80, 69);
            this.btnEditEmployee.Text = "ویرایش کارمند";
            this.btnEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Image = global::Company.App.Properties.Resources.icons8_denied_50;
            this.btnRemoveEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemoveEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(69, 69);
            this.btnRemoveEmployee.Text = "حذف کارمند";
            this.btnRemoveEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Company.App.Properties.Resources.icons8_refresh_50;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 69);
            this.btnRefresh.Text = "بروزرسانی ";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 69);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 72);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmployees.Location = new System.Drawing.Point(0, 76);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(582, 324);
            this.dgvEmployees.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NationalId";
            this.Column2.HeaderText = "کد ملی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FullName";
            this.Column3.HeaderText = "نام";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "phone";
            this.Column4.HeaderText = "تلفن";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "ایمیل";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BirthDay";
            this.Column6.HeaderText = "تولد";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnPrintInfo
            // 
            this.btnPrintInfo.Image = global::Company.App.Properties.Resources.icons8_print_50;
            this.btnPrintInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintInfo.Name = "btnPrintInfo";
            this.btnPrintInfo.Size = new System.Drawing.Size(54, 69);
            this.btnPrintInfo.Text = "چاپ";
            this.btnPrintInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintInfo.Click += new System.EventHandler(this.btnPrintInfo_Click);
            // 
            // stiReportinfo
            // 
            this.stiReportinfo.CookieContainer = null;
            this.stiReportinfo.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReportinfo.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReportinfo.ReportAlias = "Report";
            this.stiReportinfo.ReportGuid = "73b316efdb2345e2bc8ce0e757ccb439";
            this.stiReportinfo.ReportName = "Report";
            this.stiReportinfo.ReportSource = null;
            this.stiReportinfo.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReportinfo.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReportinfo.UseProgressInThread = false;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشخصات کارمندان";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewEmployee;
        private System.Windows.Forms.ToolStripButton btnEditEmployee;
        private System.Windows.Forms.ToolStripButton btnRemoveEmployee;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripButton btnPrintInfo;
        private Stimulsoft.Report.StiReport stiReportinfo;
    }
}