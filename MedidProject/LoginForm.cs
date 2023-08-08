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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new MEDIDDMEntities();
            int lblId = 1;
            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.ToString()).FirstOrDefault();
            var dt2 = Convert.ToDateTime(select.Validiti);
            var dt3 = dt2 - DateTime.Now;
            lblDate.Text = dt3.ToString("dd");

            switch (lblDate.Text)
            {
                case "00":
                    MessageBox.Show("Your license is already expired. Please update your license. Thank you!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Your license has expired. But your license and activate the software through it. Thanks!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "01":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "02":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "03":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "04":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "05":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "06":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                case "07":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    userloging();
                    break;
                default:
                    userloging();
                    break;
            }
        }

        private void userloging()
        {
            var db = new MEDIDDMEntities();
            var tb = new UserInfo();
            int lblId = 1;
            var user1 = db.UserInfoes.Where(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).FirstOrDefault();
            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.ToString()).FirstOrDefault();
            var dt1 = DateTime.Now;
            var valid = Convert.ToDateTime(select.Validiti);

            if (dt1 <= valid)
            {
                if (user1 != null)
                {
                    if (cbxTypeLog.Text == "Personal")
                    {
                        //MessageBox.Show("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cbxTypeLog.Text == "Manager")
                    {
                        //MessageBox.Show("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please check the username and password and try again.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsername.Focus();
            }
            else if (valid < dt1)
            {
                MessageBox.Show("Your license has expired. But your license and activate the software through it. Thanks!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Some thing is wrong. Log in can not possiable. Check your license and try again. Thank you!", "Login Fail", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
