namespace MedidProject
{
    partial class MotherForm
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
            this.gbLoging = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTypeLog = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoging = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToHexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisLast7DayesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dipositAndExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentDayAndNameWiseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayAndTransectionTypeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dipositMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayAndGiverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayAndReceiverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayAndPurposeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayWithGiverAndReceiverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLoging.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLoging
            // 
            this.gbLoging.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbLoging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.gbLoging.Controls.Add(this.lblDate);
            this.gbLoging.Controls.Add(this.label7);
            this.gbLoging.Controls.Add(this.label8);
            this.gbLoging.Controls.Add(this.label6);
            this.gbLoging.Controls.Add(this.label5);
            this.gbLoging.Controls.Add(this.label4);
            this.gbLoging.Controls.Add(this.cbxTypeLog);
            this.gbLoging.Controls.Add(this.pictureBox1);
            this.gbLoging.Controls.Add(this.label3);
            this.gbLoging.Controls.Add(this.label2);
            this.gbLoging.Controls.Add(this.label1);
            this.gbLoging.Controls.Add(this.btnExit);
            this.gbLoging.Controls.Add(this.btnLoging);
            this.gbLoging.Controls.Add(this.btnClean);
            this.gbLoging.Controls.Add(this.txtPassword);
            this.gbLoging.Controls.Add(this.txtUsername);
            this.gbLoging.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoging.ForeColor = System.Drawing.Color.Aqua;
            this.gbLoging.Location = new System.Drawing.Point(362, 183);
            this.gbLoging.Margin = new System.Windows.Forms.Padding(2);
            this.gbLoging.Name = "gbLoging";
            this.gbLoging.Padding = new System.Windows.Forms.Padding(2);
            this.gbLoging.Size = new System.Drawing.Size(512, 389);
            this.gbLoging.TabIndex = 4;
            this.gbLoging.TabStop = false;
            this.gbLoging.Text = "Log in";
            this.gbLoging.Visible = false;
            this.gbLoging.Enter += new System.EventHandler(this.gbLoging_Enter);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 346);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(18, 26);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = ".";
            this.lblDate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(237, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(123, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Active Mediddm";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(374, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(388, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Create Account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(256, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Forget Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxTypeLog
            // 
            this.cbxTypeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeLog.FormattingEnabled = true;
            this.cbxTypeLog.Location = new System.Drawing.Point(266, 172);
            this.cbxTypeLog.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTypeLog.Name = "cbxTypeLog";
            this.cbxTypeLog.Size = new System.Drawing.Size(214, 28);
            this.cbxTypeLog.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(266, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(266, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(266, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExit.Location = new System.Drawing.Point(375, 277);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLoging
            // 
            this.btnLoging.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoging.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoging.Location = new System.Drawing.Point(266, 222);
            this.btnLoging.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoging.Name = "btnLoging";
            this.btnLoging.Size = new System.Drawing.Size(213, 39);
            this.btnLoging.TabIndex = 4;
            this.btnLoging.Text = "Login";
            this.btnLoging.UseVisualStyleBackColor = true;
            this.btnLoging.Click += new System.EventHandler(this.btnLoging_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClean.Location = new System.Drawing.Point(266, 277);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(104, 39);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(266, 112);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(266, 54);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.medidToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1293, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalToHexadecimalToolStripMenuItem,
            this.analysisLast7DayesToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Visible = false;
            // 
            // decimalToHexadecimalToolStripMenuItem
            // 
            this.decimalToHexadecimalToolStripMenuItem.Name = "decimalToHexadecimalToolStripMenuItem";
            this.decimalToHexadecimalToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.decimalToHexadecimalToolStripMenuItem.Text = "Decimal To Hexadecimal";
            this.decimalToHexadecimalToolStripMenuItem.Visible = false;
            this.decimalToHexadecimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToHexadecimalToolStripMenuItem_Click);
            // 
            // analysisLast7DayesToolStripMenuItem
            // 
            this.analysisLast7DayesToolStripMenuItem.Name = "analysisLast7DayesToolStripMenuItem";
            this.analysisLast7DayesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.analysisLast7DayesToolStripMenuItem.Text = "Analysis Last 7 Dayes";
            this.analysisLast7DayesToolStripMenuItem.Visible = false;
            this.analysisLast7DayesToolStripMenuItem.Click += new System.EventHandler(this.analysisLast7DayesToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationToolStripMenuItem});
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Visible = false;
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dipositAndExpensesToolStripMenuItem,
            this.reportToolStripMenuItem1});
            this.personalToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Visible = false;
            // 
            // dipositAndExpensesToolStripMenuItem
            // 
            this.dipositAndExpensesToolStripMenuItem.Name = "dipositAndExpensesToolStripMenuItem";
            this.dipositAndExpensesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.dipositAndExpensesToolStripMenuItem.Text = "Diposit and Expenses";
            this.dipositAndExpensesToolStripMenuItem.Click += new System.EventHandler(this.dipositAndExpensesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem,
            this.currentDayAndNameWiseReportToolStripMenuItem,
            this.dayAndTransectionTypeReportToolStripMenuItem});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.reportToolStripMenuItem1.Text = "Report";
            // 
            // currentDayWiseDipositAndExpensesReportToolStripMenuItem
            // 
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem.Name = "currentDayWiseDipositAndExpensesReportToolStripMenuItem";
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem.Size = new System.Drawing.Size(355, 22);
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem.Text = "Current Day wise Diposit and Expenses Report";
            this.currentDayWiseDipositAndExpensesReportToolStripMenuItem.Click += new System.EventHandler(this.currentDayWiseDipositAndExpensesReportToolStripMenuItem_Click);
            // 
            // currentDayAndNameWiseReportToolStripMenuItem
            // 
            this.currentDayAndNameWiseReportToolStripMenuItem.Name = "currentDayAndNameWiseReportToolStripMenuItem";
            this.currentDayAndNameWiseReportToolStripMenuItem.Size = new System.Drawing.Size(355, 22);
            this.currentDayAndNameWiseReportToolStripMenuItem.Text = "Current Day and Name Wise Report";
            this.currentDayAndNameWiseReportToolStripMenuItem.Click += new System.EventHandler(this.currentDayAndNameWiseReportToolStripMenuItem_Click);
            // 
            // dayAndTransectionTypeReportToolStripMenuItem
            // 
            this.dayAndTransectionTypeReportToolStripMenuItem.Name = "dayAndTransectionTypeReportToolStripMenuItem";
            this.dayAndTransectionTypeReportToolStripMenuItem.Size = new System.Drawing.Size(355, 22);
            this.dayAndTransectionTypeReportToolStripMenuItem.Text = "Day and Transection Type Report";
            this.dayAndTransectionTypeReportToolStripMenuItem.Click += new System.EventHandler(this.dayAndTransectionTypeReportToolStripMenuItem_Click);
            // 
            // medidToolStripMenuItem
            // 
            this.medidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dipositMoneyToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.moneyWithdrawToolStripMenuItem,
            this.withdrawReportToolStripMenuItem});
            this.medidToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.medidToolStripMenuItem.Name = "medidToolStripMenuItem";
            this.medidToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.medidToolStripMenuItem.Text = "Medid";
            this.medidToolStripMenuItem.Visible = false;
            // 
            // dipositMoneyToolStripMenuItem
            // 
            this.dipositMoneyToolStripMenuItem.Name = "dipositMoneyToolStripMenuItem";
            this.dipositMoneyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dipositMoneyToolStripMenuItem.Text = "Diposit Money";
            this.dipositMoneyToolStripMenuItem.Click += new System.EventHandler(this.dipositMoneyToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayAndGiverReportToolStripMenuItem,
            this.dayAndReceiverReportToolStripMenuItem,
            this.dayAndPurposeReportToolStripMenuItem,
            this.dayWithGiverAndReceiverReportToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reportToolStripMenuItem.Text = "Diposit Report";
            // 
            // dayAndGiverReportToolStripMenuItem
            // 
            this.dayAndGiverReportToolStripMenuItem.Name = "dayAndGiverReportToolStripMenuItem";
            this.dayAndGiverReportToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.dayAndGiverReportToolStripMenuItem.Text = "Day and Giver Report";
            this.dayAndGiverReportToolStripMenuItem.Click += new System.EventHandler(this.dayAndGiverReportToolStripMenuItem_Click);
            // 
            // dayAndReceiverReportToolStripMenuItem
            // 
            this.dayAndReceiverReportToolStripMenuItem.Name = "dayAndReceiverReportToolStripMenuItem";
            this.dayAndReceiverReportToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.dayAndReceiverReportToolStripMenuItem.Text = "Day and Receiver Report";
            this.dayAndReceiverReportToolStripMenuItem.Click += new System.EventHandler(this.dayAndReceiverReportToolStripMenuItem_Click);
            // 
            // dayAndPurposeReportToolStripMenuItem
            // 
            this.dayAndPurposeReportToolStripMenuItem.Name = "dayAndPurposeReportToolStripMenuItem";
            this.dayAndPurposeReportToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.dayAndPurposeReportToolStripMenuItem.Text = "Day and Purpose Report";
            this.dayAndPurposeReportToolStripMenuItem.Click += new System.EventHandler(this.dayAndPurposeReportToolStripMenuItem_Click);
            // 
            // dayWithGiverAndReceiverReportToolStripMenuItem
            // 
            this.dayWithGiverAndReceiverReportToolStripMenuItem.Name = "dayWithGiverAndReceiverReportToolStripMenuItem";
            this.dayWithGiverAndReceiverReportToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.dayWithGiverAndReceiverReportToolStripMenuItem.Text = "Day with Giver and Receiver Report";
            this.dayWithGiverAndReceiverReportToolStripMenuItem.Click += new System.EventHandler(this.dayWithGiverAndReceiverReportToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // moneyWithdrawToolStripMenuItem
            // 
            this.moneyWithdrawToolStripMenuItem.Name = "moneyWithdrawToolStripMenuItem";
            this.moneyWithdrawToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.moneyWithdrawToolStripMenuItem.Text = "Money Withdraw";
            this.moneyWithdrawToolStripMenuItem.Click += new System.EventHandler(this.moneyWithdrawToolStripMenuItem_Click);
            // 
            // withdrawReportToolStripMenuItem
            // 
            this.withdrawReportToolStripMenuItem.Name = "withdrawReportToolStripMenuItem";
            this.withdrawReportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.withdrawReportToolStripMenuItem.Text = "Withdraw Report";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Visible = false;
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createUserToolStripMenuItem.Text = "Create user";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Visible = false;
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(43, 21);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLog.Location = new System.Drawing.Point(20, 692);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(13, 20);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = ".";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(677, 604);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(598, 108);
            this.lblClock.TabIndex = 12;
            this.lblClock.Text = "00:00:00 PM";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MedidProject.Properties.Resources.pexels_george_becker_333837;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 276);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 731);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.gbLoging);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "MotherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MotherForm_Load);
            this.gbLoging.ResumeLayout(false);
            this.gbLoging.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox gbLoging;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoging;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxTypeLog;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dipositMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayAndGiverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayAndReceiverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayAndPurposeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayWithGiverAndReceiverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dipositAndExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyWithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentDayWiseDipositAndExpensesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentDayAndNameWiseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayAndTransectionTypeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToHexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisLast7DayesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
    }
}



