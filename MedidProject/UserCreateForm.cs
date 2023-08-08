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
    public partial class UserCreateForm : Form
    {
        public UserCreateForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (MessageBox.Show(@"Are you sure went to create new user?", "User info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var db = new MEDIDDMEntities();
                    var tb = new UserInfo();
                    var selector = db.UserInfoes.Where(a => a.Username.ToString() == txtUsername.Text.Trim()).FirstOrDefault();

                    tb.FirstName = txtFirstname.Text.Trim();
                    tb.LastName = txtLastname.Text.Trim();
                    tb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                    tb.Username = txtUsername.Text.Trim();
                    tb.Password = txtPassword.Text.Trim();
                    if (chkHome.Checked) { tb.Home = "Y"; } else { tb.Home = "N"; }
                    if (chkInformation.Checked) { tb.Information = "Y"; } else { tb.Information = "N"; }
                    if (chkPersonal.Checked) { tb.Personal = "Y"; } else { tb.Personal = "N"; }
                    if (chkMedid.Checked) { tb.Medid = "Y"; } else { tb.Medid = "N"; }
                    if (chkSetting.Checked) { tb.Setting = "Y"; } else { tb.Setting = "N"; }
                    if (chkAbout.Checked) { tb.About = "Y"; } else { tb.About = "N"; }
                    
                    if (selector==null)
                    {
                        if (txtPassword.Text != txtRetypePassword.Text)
                        {
                            MessageBox.Show(@"Password is not matched. Please try another password and try again. Thank you!", "Password create faield!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            txtPassword.Focus();
                        }
                        else if (txtPassword.Text == txtRetypePassword.Text)
                        {
                            db.UserInfoes.Add(tb);
                            db.SaveChanges();
                            MessageBox.Show(@"New user create and permission has been save successfully.", "User create and permission info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            ClearText();
                            FillGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"username already taken. Please try another username and try again. Thank you!", "Password create faield!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    
                }
            }
            else if (btnSave.Text=="Edit")
            {
                if (MessageBox.Show(@"Are you sure went to edit user info?", "User info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var db = new MEDIDDMEntities();
                    var tb = new UserInfo();

                    var selector = db.UserInfoes.Where(a => a.Username.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

                    selector.FirstName = txtFirstname.Text.Trim();
                    selector.LastName = txtLastname.Text.Trim();
                    selector.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                    selector.Username = txtUsername.Text.Trim();
                    selector.Password = txtPassword.Text.Trim();
                    if (chkHome.Checked) { selector.Home = "Y"; } else { selector.Home = "N"; }
                    if (chkInformation.Checked) { selector.Information = "Y"; } else { selector.Information = "N"; }
                    if (chkPersonal.Checked) { selector.Personal = "Y"; } else { selector.Personal = "N"; }
                    if (chkMedid.Checked) { selector.Medid = "Y"; } else { selector.Medid = "N"; }
                    if (chkSetting.Checked) { selector.Setting = "Y"; } else { selector.Setting = "N"; }
                    if (chkAbout.Checked) { selector.About = "Y"; } else { selector.About = "N"; }
                    db.SaveChanges();
                    ClearText();
                    FillGrid();
                    btnSave.Text = "Save";
                    MessageBox.Show(@"User info and permission edit successfully.", "User create and permission edit info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtSearch.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRetypePassword.Text = string.Empty;
            chkHome.Checked = false;
            chkInformation.Checked = false;
            chkPersonal.Checked = false;
            chkMedid.Checked = false;
            chkSetting.Checked = false;
            chkAbout.Checked = false;
            btnSave.Text = "Save";
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void UserCreateForm_Load(object sender, EventArgs e)
        {
            ClearText();
            FillGrid();
        }

        private void FillGrid()
        {
            var db = new MEDIDDMEntities();
            dgvUser.DataSource = db.UserInfoes.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MEDIDDMEntities();
                var tb = new UserInfo();

                var selector = db.UserInfoes.Where(a => a.Username.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

                txtFirstname.Text = selector.FirstName;
                txtLastname.Text = selector.LastName;
                txtPhone.Text = selector.Phone.ToString();
                txtUsername.Text = selector.Username;
                txtPassword.Text = selector.Password;
                if (selector.Home == "Y") { chkHome.Checked = true; }else { chkHome.Checked = false; }
                if (selector.Information == "Y") { chkInformation.Checked = true; }else { chkInformation.Checked = false; }
                if (selector.Personal == "Y") { chkPersonal.Checked = true; }else { chkPersonal.Checked = false; }
                if (selector.Medid == "Y") { chkMedid.Checked = true; }else { chkMedid.Checked = false; }
                if (selector.Setting == "Y") { chkSetting.Checked = true; }else { chkSetting.Checked = false; }
                if (selector.About == "Y") { chkAbout.Checked = true; }else { chkAbout.Checked = false; }
                btnSave.Text = "Edit";
                btnSave.Enabled = true;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                ClearText();
                txtSearch.Focus();
            }
        }


        //======================================      username and password validation check      ===================================
        private void CheckUsernameAndPassword()
        {
            var db = new MEDIDDMEntities();
            var tb = new UserInfo();

            var selector = db.UserInfoes.Where(a => a.Username.ToString() == txtUsername.Text.Trim()).FirstOrDefault();

            if (selector != null)
            {
                MessageBox.Show(@"Username already taken. Please try another username and try again. Thank you!", "User create faield!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show(@"Password is not matched. Please try another password and try again. Thank you!", "Password create faield!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                MessageBox.Show(@"Your username & password is valid.You may proced now. Thank you!", "Username and passwoed Valid!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //======================================       username and password validation check      ===================================

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == null)
            {
                btnSearch.Enabled = false;
            }
            else if (txtSearch.Text != null)
            {
                btnSearch.Enabled = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtUsername.Text != null)
            {
                btnSave.Enabled = true;
            }
        }
    }
}
