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
    public partial class MotherForm : Form
    {
        public static string User;
        public static string currentUser;

        public MotherForm()
        {
            InitializeComponent();
        }

        private void MotherForm_Load(object sender, EventArgs e)
        {
            gbLoging.Visible = true;
            GetTypeInfo();
            timer1.Start();
        }

        private void GetTypeInfo()
        {
            var obj = new Manager();
            var list = obj.GetAllType();
            cbxTypeLog.DisplayMember = "UserType";
            cbxTypeLog.ValueMember = "It";
            cbxTypeLog.DataSource = list;
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
                        gbLoging.Visible = false;
                        if (user1.Home == "Y") { homeToolStripMenuItem.Visible = true; } else { homeToolStripMenuItem.Visible = false; }
                        if (user1.Information == "Y") { informationToolStripMenuItem.Visible = true; } else { informationToolStripMenuItem.Visible = false; }
                        if (user1.Personal == "Y") { personalToolStripMenuItem.Visible = true; } else { personalToolStripMenuItem.Visible = false; }
                        if (user1.Setting == "Y") { settingToolStripMenuItem.Visible = true; } else { settingToolStripMenuItem.Visible = false; }
                        if (user1.About == "Y") { aboutToolStripMenuItem.Visible = true; } else { aboutToolStripMenuItem.Visible = false; }

                        User = user1.FirstName + " " + user1.LastName;
                        lblLog.Show();
                        lblLog.Text = " " + User;

                        currentUser = user1.Username;
                    }
                    else if (cbxTypeLog.Text == "Manager")
                    {
                        gbLoging.Visible = false;
                        if (user1.Home == "Y") { homeToolStripMenuItem.Visible = true; } else { homeToolStripMenuItem.Visible = false; }
                        if (user1.Information == "Y") { informationToolStripMenuItem.Visible = true; } else { informationToolStripMenuItem.Visible = false; }
                        if (user1.Medid == "Y") { medidToolStripMenuItem.Visible = true; } else { medidToolStripMenuItem.Visible = false; }
                        if (user1.Setting == "Y") { settingToolStripMenuItem.Visible = true; } else { settingToolStripMenuItem.Visible = false; }
                        if (user1.About == "Y") { aboutToolStripMenuItem.Visible = true; } else { aboutToolStripMenuItem.Visible = false; }

                        User = user1.FirstName + " " + user1.LastName;
                        lblLog.Show();
                        lblLog.Text = " " + User;

                        currentUser = user1.Username;
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

        private void btnLoging_Click(object sender, EventArgs e)
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


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();      
            this.Hide(); 
            var obj = new LoginForm();
            obj.ShowDialog();     
        }

        private void gbLoging_Enter(object sender, EventArgs e)
        {
            var db = new MEDIDDMEntities();
            int lblId = 1;
            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.ToString()).FirstOrDefault();
            var dt1 = DateTime.Now;
            var valid = Convert.ToDateTime(select.Validiti);
            ActivatedLable();
            
        }

        private void ActivatedLable()
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
                    label8.Visible = true;
                    break;
                case "01":
                    label8.Visible = true;
                    break;
                case "02":
                    label8.Visible = true;
                    break;
                case "03":
                    label8.Visible = true;
                    break;
                case "04":
                    label8.Visible = true;
                    break;
                case "05":
                    label8.Visible = true;
                    break;
                case "06":
                    label8.Visible = true;
                    break;
                case "07":
                    label8.Visible = true;
                    break;
                default:
                    label8.Visible = false;
                    break;
            }
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new Student_Information();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dipositMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DipositMoneyForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new TransectionReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayAndReceiverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndReceiverReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayAndGiverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndGiverReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayAndPurposeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndPurposeReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayWithGiverAndReceiverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayWithReceiverAndGiverReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dipositAndExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new PersonalDipositForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new UserCreateForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void moneyWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MoneyWithdrawForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void currentDayWiseDipositAndExpensesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndDayDepositAndExpensesReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void currentDayAndNameWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndNameReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayAndTransectionTypeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndTransectionTypeReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void decimalToHexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DecimalToHexaDecimalForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void analysisLast7DayesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AnalysisForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DashboardForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Relax ! And try to rember the password. Or call the developer: SAMIM-HosseN", "Forget Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var obj = new ActivateForm();
            obj.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var obj = new UserCreateForm2();
            obj.ShowDialog();
        }
    }
}
