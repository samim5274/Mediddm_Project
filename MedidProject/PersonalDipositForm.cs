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
    public partial class PersonalDipositForm : Form
    {
        public PersonalDipositForm()
        {
            InitializeComponent();
        }

        private void chkDiposit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiposit.Checked)
            {
                chkExpenses.Checked = false;
                chkDiposit.Checked = true;
                gbDeposit.Enabled = true;
                gbExpenses.Enabled = false;
                lblTransectionType.Text = "0";
                txtExpensesAmount.Text = "00";
                txtDepositAmount.Text = string.Empty;
                dtpExpensesDate.Value = DateTime.Now;
            }
            else
            {
                gbDeposit.Enabled = false;
                gbExpenses.Enabled = false;
                lblTransectionType.Text = "00";
                txtExpensesAmount.Text = string.Empty;
                dtpDepositDate.Value = DateTime.Now;
                clearAll();
            }
        }

        private void chkExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpenses.Checked)
            {
                chkDiposit.Checked = false;
                chkExpenses.Checked = true;
                gbDeposit.Enabled = false;
                gbExpenses.Enabled = true;
                lblTransectionType.Text = "1";
                txtDepositAmount.Text = "00";
                txtExpensesAmount.Text = string.Empty;
                dtpDepositDate.Value = DateTime.Now;
            }
            else
            {
                gbDeposit.Enabled = false;
                gbExpenses.Enabled = false;
                lblTransectionType.Text = "00";
                txtDepositAmount.Text = string.Empty;
                dtpExpensesDate.Value = DateTime.Now;
                clearAll();
            }
        }

        private void PersonalDipositForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillGrid();
            dtpCurrentDate.Value = DateTime.Now;
            dtpDepositDate.Value = DateTime.Now;
            dtpExpensesDate.Value = DateTime.Now;
            clearAll();
            var logus = MotherForm.User;
            var logcus = MotherForm.currentUser;
            lblUser.Text = logus;
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GetPersonalTransection();
            dgvPersonalTransection.DataSource = list;
        }

        private void FillStudent()
        {
            var obj = new Manager();
            var list = obj.GetUserStudent();
            cbxName.DisplayMember = "FirstName";
            cbxName.ValueMember = "Id";
            cbxName.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
            clearAll();
            FillGrid();
        }

        private void SaveInfo()
        {
            var db = new MEDIDDMEntities();
            var tb = new PersonalDipositInfo();

            tb.DipositAmount = Convert.ToInt32(txtDepositAmount.Text.Trim());
            tb.ExpensesAmount = Convert.ToInt32(txtExpensesAmount.Text.Trim());
            tb.S_Id = Convert.ToInt32(cbxName.SelectedValue);
            tb.C_Date = Convert.ToDateTime(dtpCurrentDate.Value);
            tb.D_Date = Convert.ToDateTime(dtpDepositDate.Value);
            tb.E_Date = Convert.ToDateTime(dtpExpensesDate.Value);
            tb.Discription = txtRemark.Text.Trim();
            tb.TransectionType = Convert.ToInt32(lblTransectionType.Text);
            tb.LoginUser = lblUser.Text.Trim();
            db.PersonalDipositInfoes.Add(tb);
            db.SaveChanges();
            MessageBox.Show(@"Personal transection save successfully. Thank you!", "Save success.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            chkDiposit.Checked = false;
            chkExpenses.Checked = false;
            cbxName.Text = string.Empty;
            txtDepositAmount.Text = string.Empty;
            txtExpensesAmount.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }
        

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtDepositAmount.Text == "" || txtDepositAmount.Text == "00")
            {
                btnSave.Enabled = false;
            }
            else if (txtDepositAmount.Text != null)
            {
                if (txtDepositAmount.TextLength >= 6)
                {
                    MessageBox.Show(@"your input digit out of lenth. Please input your current number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (txtDepositAmount.TextLength < 6)
                {
                    btnSave.Enabled = true;
                }                
            }
        }

        private void txtExpensesAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtExpensesAmount.Text == "" || txtExpensesAmount.Text == "00")
            {
                btnSave.Enabled = false;
            }
            else if (txtExpensesAmount.Text != null)
            {
                if (txtExpensesAmount.TextLength >= 6)
                {
                    MessageBox.Show(@"your input digit out of lenth. Please input your current number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (txtExpensesAmount.TextLength < 6)
                {
                    btnSave.Enabled = true;
                }                
            }
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(@"Cann't use latter or another charecter. Please input only decimal number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void txtExpensesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(@"Cann't use latter or another charecter. Please input only decimal number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
