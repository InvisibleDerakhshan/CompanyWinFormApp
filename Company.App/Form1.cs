using Accounting.ViewModels.Accounting;
using Company.Business;

using Company.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Company.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Result1, Result2, Sum, Mul, Min, Div;
        Boolean OPMul, OPSum, OPMin, OPDiv;
        private bool Isclicked;

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result2 = double.Parse(txtResult.Text);
                if (OPSum == true)
                {
                    Sum = Result1 + Result2;
                    txtResult.Text = Sum.ToString();
                    OPSum = false;
                }
                else if (OPMin == true)
                {
                    Min = Result1 - Result2;
                    txtResult.Text = Min.ToString();
                    OPMin = false;
                }
                else if (OPMul == true)
                {
                    Mul = (Result1 * Result2);
                    txtResult.Text = Mul.ToString();
                    OPMul = false;
                }
                else if (OPDiv == true)
                {
                    Div = Result1 / Result2;
                    txtResult.Text = Div.ToString();
                    OPDiv = false;
                }
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                OPDiv = true;
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                OPMul = true;
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                OPMin = true;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                OPSum = true;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            gbcalculator.Hide();
            if (Isclicked)
            {
                gbcalculator.Show();

                Isclicked = false;

            }
            else
            {
                txtResult.Text = " ";
                Isclicked = true;


            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransection transection = new frmNewTransection();
            transection.ShowDialog();
        }

        private void btnRecieveRep_Click(object sender, EventArgs e)
        {
            frmReoport frmReoport = new frmReoport();
            frmReoport.TypeID = 1;
            frmReoport.ShowDialog();
        }

        private void btnPayRep_Click(object sender, EventArgs e)
        {
            frmReoport frmReoport = new frmReoport();
            frmReoport.TypeID = 2;
            frmReoport.ShowDialog();
        }

        private void btnLiveReport_Click(object sender, EventArgs e)
        {
            gbReport.Hide();
            if (Isclicked)
            {
                gbReport.Show();

                LiveReport();
                Isclicked = false;


            }
            else
            {

                Isclicked = true;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LiveReport();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (frmLogin.password == "10241380" && frmLogin.username == "invisible")
            {
                frmAddNewUser frm = new frmAddNewUser();
                frm.ShowDialog();
            }




        }

        private void lblRecieve_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnBrowseMusic_Click(object sender, EventArgs e)
        {
            
            if (Isclicked)
            {
                playerwindows.Visible = true;
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "all format(*.avi , *.mp3 ,*.mp4)| *.avi; *.mp3;*.mp4";
                if (op.ShowDialog() == DialogResult.OK)
                    playerwindows.URL = op.FileName;
                Isclicked = false;

            }
            else
            {
                playerwindows.Visible = false;
                playerwindows.currentPlaylist.clear();
                txtResult.Text = " ";
                Isclicked = true;


            }
           
        }

        private void btnmusic_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            
            btnNewUser.Visible = false;
            
            playerwindows.Visible = false;
            frmLogin frm = new frmLogin();

        

            if (frm.ShowDialog() == DialogResult.OK)
            {

                this.Show();
                
                if (frmLogin.username == "invisible" && frmLogin.password == "10241380")
                {
                    btnNewUser.Visible = true;
                }
                gbcalculator.Hide();
                gbReport.Hide();
                
                lblDate.Text = DateConverter.Toshamsi(DateTime.Now);
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

            }
            else
            {
                Application.Exit();
            }

            //RtlMessageBox.Show("خوش آمدید، در صورت وجود ابهام بر روی راهنما کلیک کنید", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RtlMessageBox.Show("  برای مشاهده وایجاد هرگونه تغییر در لیست کارمندان از دکمه مخصوص استفاده کنید", "1/5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RtlMessageBox.Show("  برای مشاهده لیست مشتریان و ایجاد هرگونه تغییر از دکمه مخصوص این فرایند استفاده کنید", "2/5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RtlMessageBox.Show(" برای استفاده از ماشین حساب بر روی آن کلیک کنید تا باز شود و بعد از اتمام کار دوباره کلیک کنید تا بسته شود ", "3/5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RtlMessageBox.Show(" اگر در مرحله ای بعد از فشردن دکمه ثبت با علامت ستاره مواجه شدید به معنی الزامی بودن فیلد مورد نظر میباشد ", "4/5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RtlMessageBox.Show(" برای پخش  ویدیو و موزیک برروی دکمه مورد نظر کلیک کنید و فایل مورد نظر را انتخاب کنید وبرای بستن دوباره همان کلید را بفشارید ", "4/5", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        void LiveReport()
        {
            ReportViewModel rp = Transection.ReportFormMain();
            lblPay.Text = rp.Pay.ToString("#,0");
            lblRecieve.Text = rp.Recive.ToString("#,0");
            lblAccountBalance.Text = rp.AccountingBalance.ToString("#,0");

        }
       

    }
}
