
namespace Company.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEditLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.btnNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnEmployees = new System.Windows.Forms.ToolStripButton();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnRecieveRep = new System.Windows.Forms.ToolStripButton();
            this.btnPayRep = new System.Windows.Forms.ToolStripButton();
            this.btnLiveReport = new System.Windows.Forms.ToolStripButton();
            this.btnCalculator = new System.Windows.Forms.ToolStripButton();
            this.btnBrowseMusic = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbcalculator = new System.Windows.Forms.GroupBox();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcLoginSucces = new System.Windows.Forms.PictureBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.playerwindows = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbcalculator.SuspendLayout();
            this.gbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLoginSucces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerwindows)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnInfo,
            this.btnNewUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditLogin});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "تنظیمات";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(142, 22);
            this.btnEditLogin.Text = "تنظیمات ورود";
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::Company.App.Properties.Resources.icons8_information;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(56, 22);
            this.btnInfo.Text = "راهنما";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Image = global::Company.App.Properties.Resources.icons8_male_user;
            this.btnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(112, 22);
            this.btnNewUser.Text = "افزودن کاربر جدید";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmployees,
            this.btnCustomers,
            this.btnTransaction,
            this.btnRecieveRep,
            this.btnPayRep,
            this.btnLiveReport,
            this.btnCalculator,
            this.btnBrowseMusic});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 72);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Image = global::Company.App.Properties.Resources.icons8_users_50;
            this.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(54, 69);
            this.btnEmployees.Text = "کارمندان";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Company.App.Properties.Resources.icons8_employee_50;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(54, 69);
            this.btnCustomers.Text = "مشتریان";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Image = global::Company.App.Properties.Resources.icons8_split_transaction_50;
            this.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(72, 69);
            this.btnTransaction.Text = "تراکنش جدید";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnRecieveRep
            // 
            this.btnRecieveRep.Image = global::Company.App.Properties.Resources.icons8_payment_history_50__2_;
            this.btnRecieveRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRecieveRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecieveRep.Name = "btnRecieveRep";
            this.btnRecieveRep.Size = new System.Drawing.Size(111, 69);
            this.btnRecieveRep.Text = "تراکنش های دریافتی";
            this.btnRecieveRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecieveRep.Click += new System.EventHandler(this.btnRecieveRep_Click);
            // 
            // btnPayRep
            // 
            this.btnPayRep.Image = global::Company.App.Properties.Resources.icons8_payment_history_50__1_;
            this.btnPayRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayRep.Name = "btnPayRep";
            this.btnPayRep.Size = new System.Drawing.Size(110, 69);
            this.btnPayRep.Text = "تراکنش های پرداختی";
            this.btnPayRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayRep.Click += new System.EventHandler(this.btnPayRep_Click);
            // 
            // btnLiveReport
            // 
            this.btnLiveReport.Image = global::Company.App.Properties.Resources.icons8_report_50__2_;
            this.btnLiveReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLiveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLiveReport.Name = "btnLiveReport";
            this.btnLiveReport.Size = new System.Drawing.Size(87, 69);
            this.btnLiveReport.Text = "گزارش لحظه ای";
            this.btnLiveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLiveReport.Click += new System.EventHandler(this.btnLiveReport_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Image = global::Company.App.Properties.Resources.icons8_calculator_50;
            this.btnCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(77, 69);
            this.btnCalculator.Text = "ماشین حساب";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnBrowseMusic
            // 
            this.btnBrowseMusic.Image = global::Company.App.Properties.Resources.icons8_musical_notes_50;
            this.btnBrowseMusic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBrowseMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowseMusic.Name = "btnBrowseMusic";
            this.btnBrowseMusic.Size = new System.Drawing.Size(98, 69);
            this.btnBrowseMusic.Text = "پخش آهنگ و فیلم";
            this.btnBrowseMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBrowseMusic.Click += new System.EventHandler(this.btnBrowseMusic_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonDiv.Location = new System.Drawing.Point(252, 99);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(40, 34);
            this.buttonDiv.TabIndex = 36;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonEqual.Location = new System.Drawing.Point(187, 288);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(40, 34);
            this.buttonEqual.TabIndex = 35;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(117, 288);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 34);
            this.button0.TabIndex = 34;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(47, 288);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(40, 34);
            this.buttonC.TabIndex = 33;
            this.buttonC.Text = "c";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSum.Location = new System.Drawing.Point(252, 288);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(40, 34);
            this.buttonSum.TabIndex = 32;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(187, 226);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 34);
            this.button9.TabIndex = 31;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(117, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 34);
            this.button8.TabIndex = 30;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(47, 226);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 34);
            this.button7.TabIndex = 29;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMin.Location = new System.Drawing.Point(252, 226);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(40, 34);
            this.buttonMin.TabIndex = 28;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 34);
            this.button6.TabIndex = 27;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMul.Location = new System.Drawing.Point(252, 163);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(40, 34);
            this.buttonMul.TabIndex = 26;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 34);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 34);
            this.button4.TabIndex = 24;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtResult.Location = new System.Drawing.Point(35, 42);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(281, 22);
            this.txtResult.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbcalculator
            // 
            this.gbcalculator.Controls.Add(this.txtResult);
            this.gbcalculator.Controls.Add(this.buttonDiv);
            this.gbcalculator.Controls.Add(this.button1);
            this.gbcalculator.Controls.Add(this.buttonEqual);
            this.gbcalculator.Controls.Add(this.button2);
            this.gbcalculator.Controls.Add(this.button0);
            this.gbcalculator.Controls.Add(this.button3);
            this.gbcalculator.Controls.Add(this.buttonC);
            this.gbcalculator.Controls.Add(this.button4);
            this.gbcalculator.Controls.Add(this.buttonSum);
            this.gbcalculator.Controls.Add(this.button5);
            this.gbcalculator.Controls.Add(this.button9);
            this.gbcalculator.Controls.Add(this.buttonMul);
            this.gbcalculator.Controls.Add(this.button8);
            this.gbcalculator.Controls.Add(this.button6);
            this.gbcalculator.Controls.Add(this.button7);
            this.gbcalculator.Controls.Add(this.buttonMin);
            this.gbcalculator.Location = new System.Drawing.Point(12, 155);
            this.gbcalculator.Name = "gbcalculator";
            this.gbcalculator.Size = new System.Drawing.Size(349, 335);
            this.gbcalculator.TabIndex = 37;
            this.gbcalculator.TabStop = false;
            this.gbcalculator.Text = "ماشین حساب";
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.pictureBox1);
            this.gbReport.Controls.Add(this.pcLoginSucces);
            this.gbReport.Controls.Add(this.lblAccountBalance);
            this.gbReport.Controls.Add(this.lblPay);
            this.gbReport.Controls.Add(this.lblRecieve);
            this.gbReport.Controls.Add(this.label3);
            this.gbReport.Controls.Add(this.label2);
            this.gbReport.Controls.Add(this.label1);
            this.gbReport.Location = new System.Drawing.Point(414, 130);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(358, 158);
            this.gbReport.TabIndex = 38;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "گرارش لحظه ای";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.App.Properties.Resources.icons8_live_100;
            this.pictureBox1.Location = new System.Drawing.Point(272, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pcLoginSucces
            // 
            this.pcLoginSucces.Image = global::Company.App.Properties.Resources.icons8_combo_chart;
            this.pcLoginSucces.Location = new System.Drawing.Point(6, 13);
            this.pcLoginSucces.Name = "pcLoginSucces";
            this.pcLoginSucces.Size = new System.Drawing.Size(114, 138);
            this.pcLoginSucces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLoginSucces.TabIndex = 7;
            this.pcLoginSucces.TabStop = false;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(33, 75);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(221, 23);
            this.lblAccountBalance.TabIndex = 5;
            this.lblAccountBalance.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(33, 52);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(221, 23);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblRecieve
            // 
            this.lblRecieve.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieve.Location = new System.Drawing.Point(33, 25);
            this.lblRecieve.Name = "lblRecieve";
            this.lblRecieve.Size = new System.Drawing.Size(221, 23);
            this.lblRecieve.TabIndex = 3;
            this.lblRecieve.Text = "0";
            this.lblRecieve.Click += new System.EventHandler(this.lblRecieve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده حساب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "f3588038119c493d80d4b82f44083ab9";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // playerwindows
            // 
            this.playerwindows.Enabled = true;
            this.playerwindows.Location = new System.Drawing.Point(414, 318);
            this.playerwindows.Name = "playerwindows";
            this.playerwindows.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerwindows.OcxState")));
            this.playerwindows.Size = new System.Drawing.Size(348, 201);
            this.playerwindows.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.playerwindows);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbcalculator);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار شرکت";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbcalculator.ResumeLayout(false);
            this.gbcalculator.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLoginSucces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerwindows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btnEditLogin;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnEmployees;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbcalculator;
        private System.Windows.Forms.ToolStripButton btnCalculator;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton btnRecieveRep;
        private System.Windows.Forms.ToolStripButton btnPayRep;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecieve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnLiveReport;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pcLoginSucces;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripButton btnNewUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer playerwindows;
        private System.Windows.Forms.ToolStripButton btnBrowseMusic;
    }
}

