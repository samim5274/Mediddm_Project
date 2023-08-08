namespace MedidProject
{
    partial class DipositMoneyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblMoneyType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvGivenAndRecive = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPShowTransectionDataInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDIDDMDataSet3 = new MedidProject.MEDIDDMDataSet3();
            this.sPShowTransectionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.chkGivenMoney = new System.Windows.Forms.CheckBox();
            this.chkTaking = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxGiverName = new System.Windows.Forms.ComboBox();
            this.cbxReciverName = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCUsername = new System.Windows.Forms.Label();
            this.sP_Show_Transection_Data_InfoTableAdapter = new MedidProject.MEDIDDMDataSet3TableAdapters.SP_Show_Transection_Data_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenAndRecive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPShowTransectionDataInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDIDDMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPShowTransectionDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Me Taking or Give";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(301, 160);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(90, 25);
            this.lblTime2.TabIndex = 46;
            this.lblTime2.Text = "00:00:00";
            this.lblTime2.Visible = false;
            // 
            // lblMoneyType
            // 
            this.lblMoneyType.AutoSize = true;
            this.lblMoneyType.Location = new System.Drawing.Point(536, 450);
            this.lblMoneyType.Name = "lblMoneyType";
            this.lblMoneyType.Size = new System.Drawing.Size(24, 17);
            this.lblMoneyType.TabIndex = 45;
            this.lblMoneyType.Text = "00";
            this.lblMoneyType.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(578, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 33);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvGivenAndRecive
            // 
            this.dgvGivenAndRecive.AllowUserToAddRows = false;
            this.dgvGivenAndRecive.AllowUserToDeleteRows = false;
            this.dgvGivenAndRecive.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGivenAndRecive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGivenAndRecive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGivenAndRecive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.giverNameDataGridViewTextBoxColumn,
            this.reciverNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvGivenAndRecive.DataSource = this.sPShowTransectionDataInfoBindingSource;
            this.dgvGivenAndRecive.Location = new System.Drawing.Point(725, 184);
            this.dgvGivenAndRecive.Name = "dgvGivenAndRecive";
            this.dgvGivenAndRecive.ReadOnly = true;
            this.dgvGivenAndRecive.RowHeadersVisible = false;
            this.dgvGivenAndRecive.RowTemplate.Height = 24;
            this.dgvGivenAndRecive.Size = new System.Drawing.Size(554, 437);
            this.dgvGivenAndRecive.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // giverNameDataGridViewTextBoxColumn
            // 
            this.giverNameDataGridViewTextBoxColumn.DataPropertyName = "Giver_Name";
            this.giverNameDataGridViewTextBoxColumn.HeaderText = "Giver Name";
            this.giverNameDataGridViewTextBoxColumn.Name = "giverNameDataGridViewTextBoxColumn";
            this.giverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciverNameDataGridViewTextBoxColumn
            // 
            this.reciverNameDataGridViewTextBoxColumn.DataPropertyName = "Reciver_Name";
            this.reciverNameDataGridViewTextBoxColumn.HeaderText = "Reciver Name";
            this.reciverNameDataGridViewTextBoxColumn.Name = "reciverNameDataGridViewTextBoxColumn";
            this.reciverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "C_User";
            this.dataGridViewTextBoxColumn3.HeaderText = "Current User";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "P_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purpose Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn6.HeaderText = "Money";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // sPShowTransectionDataInfoBindingSource
            // 
            this.sPShowTransectionDataInfoBindingSource.DataMember = "SP_Show_Transection_Data_Info";
            this.sPShowTransectionDataInfoBindingSource.DataSource = this.mEDIDDMDataSet3;
            // 
            // mEDIDDMDataSet3
            // 
            this.mEDIDDMDataSet3.DataSetName = "MEDIDDMDataSet3";
            this.mEDIDDMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPShowTransectionDetailBindingSource
            // 
            this.sPShowTransectionDetailBindingSource.DataMember = "SP_Show_Transection_Detail";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(378, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 28);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(675, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 33);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(578, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 33);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(578, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 33);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(306, 487);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(254, 28);
            this.txtMoney.TabIndex = 39;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(306, 259);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(254, 22);
            this.dtpDate.TabIndex = 38;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(56, 54);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 25);
            this.lblTime.TabIndex = 37;
            this.lblTime.Text = "00:00:00";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(306, 538);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(254, 127);
            this.txtRemark.TabIndex = 36;
            this.txtRemark.Text = "N/A";
            // 
            // chkGivenMoney
            // 
            this.chkGivenMoney.AutoSize = true;
            this.chkGivenMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGivenMoney.Location = new System.Drawing.Point(306, 444);
            this.chkGivenMoney.Name = "chkGivenMoney";
            this.chkGivenMoney.Size = new System.Drawing.Size(79, 28);
            this.chkGivenMoney.TabIndex = 33;
            this.chkGivenMoney.Text = "I Give";
            this.chkGivenMoney.UseVisualStyleBackColor = true;
            this.chkGivenMoney.CheckedChanged += new System.EventHandler(this.chkGivenMoney_CheckedChanged);
            // 
            // chkTaking
            // 
            this.chkTaking.AutoSize = true;
            this.chkTaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTaking.Location = new System.Drawing.Point(420, 444);
            this.chkTaking.Name = "chkTaking";
            this.chkTaking.Size = new System.Drawing.Size(110, 28);
            this.chkTaking.TabIndex = 32;
            this.chkTaking.Text = "I\'m taking";
            this.chkTaking.UseVisualStyleBackColor = true;
            this.chkTaking.CheckedChanged += new System.EventHandler(this.chkTaking_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Resion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Reciver Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giver Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 44);
            this.label2.TabIndex = 27;
            this.label2.Text = "Moeny Given and Recived Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1249, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxGiverName
            // 
            this.cbxGiverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxGiverName.FormattingEnabled = true;
            this.cbxGiverName.Location = new System.Drawing.Point(306, 296);
            this.cbxGiverName.Name = "cbxGiverName";
            this.cbxGiverName.Size = new System.Drawing.Size(254, 30);
            this.cbxGiverName.TabIndex = 49;
            // 
            // cbxReciverName
            // 
            this.cbxReciverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxReciverName.FormattingEnabled = true;
            this.cbxReciverName.Location = new System.Drawing.Point(306, 344);
            this.cbxReciverName.Name = "cbxReciverName";
            this.cbxReciverName.Size = new System.Drawing.Size(254, 30);
            this.cbxReciverName.TabIndex = 50;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(27, 678);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 25);
            this.lblUsername.TabIndex = 51;
            this.lblUsername.Text = "label8";
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Location = new System.Drawing.Point(306, 390);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(254, 30);
            this.cbxPurpose.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 52;
            this.label8.Text = "Purpose";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Time";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "User";
            this.label10.Visible = false;
            // 
            // lblCUsername
            // 
            this.lblCUsername.AutoSize = true;
            this.lblCUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUsername.Location = new System.Drawing.Point(302, 206);
            this.lblCUsername.Name = "lblCUsername";
            this.lblCUsername.Size = new System.Drawing.Size(58, 24);
            this.lblCUsername.TabIndex = 56;
            this.lblCUsername.Text = "name";
            this.lblCUsername.Visible = false;
            // 
            // sP_Show_Transection_Data_InfoTableAdapter
            // 
            this.sP_Show_Transection_Data_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // DipositMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1348, 725);
            this.Controls.Add(this.lblCUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxPurpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cbxReciverName);
            this.Controls.Add(this.cbxGiverName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblMoneyType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvGivenAndRecive);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.chkGivenMoney);
            this.Controls.Add(this.chkTaking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DipositMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DipositMoneyForm";
            this.Load += new System.EventHandler(this.DipositMoneyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenAndRecive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPShowTransectionDataInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDIDDMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPShowTransectionDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblMoneyType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvGivenAndRecive;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.CheckBox chkGivenMoney;
        private System.Windows.Forms.CheckBox chkTaking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbxGiverName;
        private System.Windows.Forms.ComboBox cbxReciverName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbxPurpose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCUsername;
        //private MEDIDDMDataSet3 mEDIDDMDataSet3;
        private System.Windows.Forms.BindingSource sPShowTransectionDetailBindingSource;
        //private MEDIDDMDataSet3TableAdapters.SP_Show_Transection_DetailTableAdapter sP_Show_Transection_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private MEDIDDMDataSet3 mEDIDDMDataSet3;
        private System.Windows.Forms.BindingSource sPShowTransectionDataInfoBindingSource;
        private MEDIDDMDataSet3TableAdapters.SP_Show_Transection_Data_InfoTableAdapter sP_Show_Transection_Data_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}