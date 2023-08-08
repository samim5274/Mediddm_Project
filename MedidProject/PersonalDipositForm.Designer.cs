namespace MedidProject
{
    partial class PersonalDipositForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.chkDiposit = new System.Windows.Forms.CheckBox();
            this.chkExpenses = new System.Windows.Forms.CheckBox();
            this.lblTransectionType = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.txtExpensesAmount = new System.Windows.Forms.TextBox();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepositDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
            this.gbExpenses = new System.Windows.Forms.GroupBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPersonalTransection = new System.Windows.Forms.DataGridView();
            this.gbDeposit.SuspendLayout();
            this.gbExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalTransection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(22, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // chkDiposit
            // 
            this.chkDiposit.AutoSize = true;
            this.chkDiposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiposit.Location = new System.Drawing.Point(337, 107);
            this.chkDiposit.Name = "chkDiposit";
            this.chkDiposit.Size = new System.Drawing.Size(125, 36);
            this.chkDiposit.TabIndex = 8;
            this.chkDiposit.Text = "Diposit";
            this.chkDiposit.UseVisualStyleBackColor = true;
            this.chkDiposit.CheckedChanged += new System.EventHandler(this.chkDiposit_CheckedChanged);
            // 
            // chkExpenses
            // 
            this.chkExpenses.AutoSize = true;
            this.chkExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExpenses.Location = new System.Drawing.Point(531, 107);
            this.chkExpenses.Name = "chkExpenses";
            this.chkExpenses.Size = new System.Drawing.Size(162, 36);
            this.chkExpenses.TabIndex = 9;
            this.chkExpenses.Text = "Expenses";
            this.chkExpenses.UseVisualStyleBackColor = true;
            this.chkExpenses.CheckedChanged += new System.EventHandler(this.chkExpenses_CheckedChanged);
            // 
            // lblTransectionType
            // 
            this.lblTransectionType.AutoSize = true;
            this.lblTransectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransectionType.Location = new System.Drawing.Point(477, 111);
            this.lblTransectionType.Name = "lblTransectionType";
            this.lblTransectionType.Size = new System.Drawing.Size(39, 29);
            this.lblTransectionType.TabIndex = 10;
            this.lblTransectionType.Text = "00";
            this.lblTransectionType.Visible = false;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmount.Location = new System.Drawing.Point(221, 76);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(353, 30);
            this.txtDepositAmount.TabIndex = 11;
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            this.txtDepositAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositAmount_KeyPress);
            // 
            // txtExpensesAmount
            // 
            this.txtExpensesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesAmount.Location = new System.Drawing.Point(217, 78);
            this.txtExpensesAmount.Name = "txtExpensesAmount";
            this.txtExpensesAmount.Size = new System.Drawing.Size(353, 30);
            this.txtExpensesAmount.TabIndex = 12;
            this.txtExpensesAmount.TextChanged += new System.EventHandler(this.txtExpensesAmount_TextChanged);
            this.txtExpensesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpensesAmount_KeyPress);
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Enabled = false;
            this.dtpCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCurrentDate.Location = new System.Drawing.Point(326, 62);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(353, 27);
            this.dtpCurrentDate.TabIndex = 13;
            // 
            // dtpDepositDate
            // 
            this.dtpDepositDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepositDate.Location = new System.Drawing.Point(221, 30);
            this.dtpDepositDate.Name = "dtpDepositDate";
            this.dtpDepositDate.Size = new System.Drawing.Size(353, 27);
            this.dtpDepositDate.TabIndex = 14;
            // 
            // dtpExpensesDate
            // 
            this.dtpExpensesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpensesDate.Location = new System.Drawing.Point(217, 33);
            this.dtpExpensesDate.Name = "dtpExpensesDate";
            this.dtpExpensesDate.Size = new System.Drawing.Size(353, 27);
            this.dtpExpensesDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Deposit Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Expenses Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deposit Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Expenses Amount";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(322, 525);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(353, 118);
            this.txtRemark.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Discription";
            // 
            // gbDeposit
            // 
            this.gbDeposit.Controls.Add(this.txtDepositAmount);
            this.gbDeposit.Controls.Add(this.label4);
            this.gbDeposit.Controls.Add(this.dtpDepositDate);
            this.gbDeposit.Controls.Add(this.label2);
            this.gbDeposit.Enabled = false;
            this.gbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeposit.Location = new System.Drawing.Point(105, 216);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(606, 143);
            this.gbDeposit.TabIndex = 22;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Deposit";
            // 
            // gbExpenses
            // 
            this.gbExpenses.Controls.Add(this.txtExpensesAmount);
            this.gbExpenses.Controls.Add(this.dtpExpensesDate);
            this.gbExpenses.Controls.Add(this.label3);
            this.gbExpenses.Controls.Add(this.label5);
            this.gbExpenses.Enabled = false;
            this.gbExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExpenses.Location = new System.Drawing.Point(105, 368);
            this.gbExpenses.Name = "gbExpenses";
            this.gbExpenses.Size = new System.Drawing.Size(606, 143);
            this.gbExpenses.TabIndex = 23;
            this.gbExpenses.TabStop = false;
            this.gbExpenses.Text = "Expenses";
            // 
            // cbxName
            // 
            this.cbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(326, 161);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(353, 33);
            this.cbxName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Student Name";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(322, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 34);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(514, 664);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 34);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvPersonalTransection
            // 
            this.dgvPersonalTransection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalTransection.Location = new System.Drawing.Point(737, 161);
            this.dgvPersonalTransection.Name = "dgvPersonalTransection";
            this.dgvPersonalTransection.RowTemplate.Height = 24;
            this.dgvPersonalTransection.Size = new System.Drawing.Size(636, 537);
            this.dgvPersonalTransection.TabIndex = 27;
            // 
            // PersonalDipositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1421, 730);
            this.Controls.Add(this.dgvPersonalTransection);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.gbExpenses);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dtpCurrentDate);
            this.Controls.Add(this.lblTransectionType);
            this.Controls.Add(this.chkExpenses);
            this.Controls.Add(this.chkDiposit);
            this.Controls.Add(this.lblUser);
            this.Name = "PersonalDipositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalDipositForm";
            this.Load += new System.EventHandler(this.PersonalDipositForm_Load);
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            this.gbExpenses.ResumeLayout(false);
            this.gbExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalTransection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckBox chkDiposit;
        private System.Windows.Forms.CheckBox chkExpenses;
        private System.Windows.Forms.Label lblTransectionType;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.TextBox txtExpensesAmount;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.DateTimePicker dtpDepositDate;
        private System.Windows.Forms.DateTimePicker dtpExpensesDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDeposit;
        private System.Windows.Forms.GroupBox gbExpenses;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPersonalTransection;
    }
}