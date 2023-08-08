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
    public partial class UserCreateForm2 : Form
    {
        public UserCreateForm2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (MessageBox.Show(@"Are you sure went to create new user?", "User info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var db = new MEDIDDMEntities();
                        var tb = new UserInfo();
                        var selector = db.UserInfoes.Where(a => a.Username.ToString() == txtUsername.Text.Trim()).FirstOrDefault();

                        tb.FirstName = txtFirstname.Text.Trim();
                        tb.LastName = txtLastname.Text.Trim();
                        tb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                        tb.Username = txtUsername.Text.Trim();
                        tb.Password = txtPassword.Text.Trim();

                        if (selector == null)
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
                                //FillGrid();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"username already taken. Please try another username and try again. Thank you!", "Password create faield!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            txtUsername.Focus();
                        }
                    }
                    catch 
                    {
                        MessageBox.Show(@"username create not possible. Please try again. Thank you!", "User create fail!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else if (btnSave.Text == "#")
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
                    db.SaveChanges();
                    ClearText();
                    FillGrid();
                    btnSave.Text = "Save";
                    MessageBox.Show(@"User info and permission edit successfully.", "User create and permission edit info!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(@"You cann't changed anything right now. Please try again. Thank you!", "Data edit not possible.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
            }
        }

        private void UserCreateForm2_Load(object sender, EventArgs e)
        {
            ClearText();
            //FillGrid();
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
            btnSave.Text = "Save";
            btnSearch.Enabled = false;
        }

        private void FillGrid()
        {
            var db = new MEDIDDMEntities();
            dgvUser.DataSource = db.UserInfoes.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
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
    }
}
