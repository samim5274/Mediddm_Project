using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedidProject
{
    public partial class DipositMoneyForm : Form
    {
        public DipositMoneyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void DipositMoneyForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ClearText();
            FillStudentName();
            FillStudentName2();
            FillPurpose();
            var logus = MotherForm.User;
            var logcus = MotherForm.currentUser;
            lblUsername.Text = " "+logus;
            FillGrid();
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GettAllTransection();
            dgvGivenAndRecive.DataSource = list;
        }

        private void FillPurpose()
        {
            var obj = new Manager();
            var list = obj.GettAllPurpose();
            cbxPurpose.DisplayMember = "P_Name";
            cbxPurpose.ValueMember = "P_Id";
            cbxPurpose.DataSource = list;
        }

        private void FillStudentName2()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxReciverName.DisplayMember = "S_Name";
            cbxReciverName.ValueMember = "Id";
            cbxReciverName.DataSource = list;
        }

        private void FillStudentName()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxGiverName.DisplayMember = "S_Name";
            cbxGiverName.ValueMember = "Id";
            cbxGiverName.DataSource = list;
        }

        private void chkGivenMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGivenMoney.Checked)
            {
                chkTaking.Checked = false;
                txtMoney.Enabled = true;
                lblMoneyType.Text = "0";
            }
            else
            {
                txtMoney.Enabled = false;
                lblMoneyType.Text = "00";
                txtMoney.Text = string.Empty;
            }
        }

        private void chkTaking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaking.Checked)
            {
                chkGivenMoney.Checked = false;
                txtMoney.Enabled = true;
                lblMoneyType.Text = "1";
            }
            else
            {
                txtMoney.Enabled = false;
                lblMoneyType.Text = "00";
                txtMoney.Text = string.Empty;
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text == "" )
            {
                btnSave.Enabled = false;
            }
            else if (txtMoney.Text != null)
            {
                if (txtMoney.TextLength >= 6)
                {
                    MessageBox.Show(@"your input digit out of lenth. Please input your current number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (txtMoney.TextLength <= 6 )
                {
                    btnSave.Enabled = true;
                }      
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(@"Cann't use latter or another charecter. Please input only decimal number. Thank you.","Erorr input",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                SaveInfo();
                ClearText();
                FillGrid();
            }
            else if (btnSave.Text=="Edit")
            {
                EditInfo();
                ClearText();
                FillGrid();
            }
        }

        private void EditInfo()
        {
            if (MessageBox.Show(@"Are you going to edited the data? Are you sure to edit the transection history?", "Transection edit info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MEDIDDMEntities();

                var info = db.MoneyTransectionTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();

                info.Date = Convert.ToDateTime(dtpDate.Value);
                info.Time = lblTime.Text.Trim();
                info.GiverId = Convert.ToInt32(cbxGiverName.SelectedValue);
                info.ReciverId = Convert.ToInt32(cbxReciverName.SelectedValue);
                info.PurposeId = Convert.ToInt32(cbxPurpose.SelectedValue);
                info.MoneyType = Convert.ToInt32(lblMoneyType.Text);
                info.Money = Convert.ToInt32(txtMoney.Text.Trim());
                info.Remark = txtRemark.Text.Trim();
                
                db.SaveChanges();
                MessageBox.Show(@"Your diposit money transection has been edited successfully.", "Save  info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void SaveInfo()
        {
            if (MessageBox.Show(@"Are you sure to save the transection?","Transection info!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var db = new MEDIDDMEntities();
                var tb = new MoneyTransectionTable();

                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.Time = lblTime.Text.Trim();
                tb.GiverId = Convert.ToInt32(cbxGiverName.SelectedValue);
                tb.ReciverId = Convert.ToInt32(cbxReciverName.SelectedValue);
                tb.PurposeId = Convert.ToInt32(cbxPurpose.SelectedValue);
                tb.MoneyType = Convert.ToInt32(lblMoneyType.Text);
                tb.Money = Convert.ToInt32(txtMoney.Text.Trim());
                tb.Remark = txtRemark.Text.Trim();
                tb.C_User = lblUsername.Text.Trim();

                db.MoneyTransectionTables.Add(tb);
                db.SaveChanges();
                MessageBox.Show(@"Your diposit money transection has been save successfully.", "Save  info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            cbxGiverName.Text = string.Empty;
            cbxReciverName.Text = string.Empty;
            cbxPurpose.Text = string.Empty;
            chkGivenMoney.Checked = false;
            chkTaking.Checked = false;
            txtMoney.Text = string.Empty;
            txtRemark.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            txtSearch.Text = string.Empty;
            lblTime2.Visible = false;
            lblCUsername.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MEDIDDMEntities();

                var selector = db.MoneyTransectionTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();

                cbxGiverName.SelectedValue = selector.GiverId;
                cbxReciverName.SelectedValue = selector.ReciverId;
                cbxPurpose.SelectedValue = selector.PurposeId;
                dtpDate.Value = Convert.ToDateTime(selector.Date);
                lblTime2.Text = selector.Time;
                lblTime2.Visible = true;
                txtRemark.Text = selector.Remark;
                txtMoney.Text = selector.Money.ToString();
                lblMoneyType.Text = selector.MoneyType.ToString();
                if (lblMoneyType.Text == "0")
                {
                    chkGivenMoney.Checked = true;
                }
                else if (lblMoneyType.Text == "1")
                {
                    chkTaking.Checked = true;
                }
                else
                {
                    chkTaking.Checked = false;
                    chkGivenMoney.Checked = false;
                }
                btnSave.Text = "Edit";
                btnDelete.Enabled = true;
                lblCUsername.Text = selector.C_User;
                lblCUsername.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search ineffectual !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text=="")
            {
                btnSearch.Enabled = false;
            }
            else if (txtSearch.Text != null)
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you going to delete the data? Are you sure to delete the transection history?", "Transection delete info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MEDIDDMEntities();

                var selector = db.MoneyTransectionTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();

                db.MoneyTransectionTables.Remove(selector);
                db.SaveChanges();
                MessageBox.Show(@"Your diposit money transection has been deleted successfully.", "Delete info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearText();
                FillGrid();
            }
        }
        
    }
}
