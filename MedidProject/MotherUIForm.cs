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
    public partial class MotherUIForm : Form
    {
        public static string User;
        public static string currentUser;

        public MotherUIForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MotherUIForm_Load(object sender, EventArgs e)
        {
            gbLoging.Visible = true;
            AllGroupBoxVisiableFalse();            
            GetTypeInfo();
        }

        private void AllGroupBoxVisiableFalse()
        {
            gbInformation.Visible = false;
            gbMediddm.Visible = false;
            gbMenu.Visible = false;
            gbPersonal.Visible = false;
            gbSetting.Visible = false;
            gbHome.Visible = false;
        }

        private void GetTypeInfo()
        {
            var obj = new Manager();
            var list = obj.GetAllType();
            cbxType.DisplayMember = "UserType";
            cbxType.ValueMember = "It";
            cbxType.DataSource = list;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Relax ! And try to rember the password. Or call the developer SAMIM-HosseN","Forget Password",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userloging();
        }

        private void userloging()
        {
            var db = new MEDIDDMEntities();
            var tb = new UserInfo();

            var user1 = db.UserInfoes.Where(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).FirstOrDefault();

            if (user1 != null)
            {
                if (cbxType.Text == "Personal")
                {
                    gbLoging.Visible = false;
                    if (user1.Home == "Y") { lblHome.Visible = true; } else { lblHome.Visible = false; }
                    if (user1.Information == "Y") { lblInformation.Visible = true; } else { lblInformation.Visible = false; }
                    if (user1.Personal == "Y") { lblPersonal.Visible = true; } else { lblPersonal.Visible = false; }
                    if (user1.Setting == "Y") { lblSetting.Visible = true; } else { lblSetting.Visible = false; }
                    if (user1.About == "Y") { lblAbout.Visible = true; } else { lblAbout.Visible = false; }
                    gbMenu.Visible = true;
                    lblMenoHide.Visible = true;
                    pbMenu.Visible = false;
                    User = user1.FirstName + " " + user1.LastName;
                    lblLog.Show();
                    lblLog.Text = " " + User;
                    currentUser = user1.Username;
                }
                else if (cbxType.Text == "Manager")
                {
                    gbLoging.Visible = false;
                    if (user1.Home == "Y") { lblHome.Visible = true; } else { lblHome.Visible = false; }
                    if (user1.Information == "Y") { lblInformation.Visible = true; } else { lblInformation.Visible = false; }
                    if (user1.Medid == "Y") { lblMediddm.Visible = true; } else { lblMediddm.Visible = false; }
                    if (user1.Setting == "Y") { lblSetting.Visible = true; } else { lblSetting.Visible = false; }
                    if (user1.About == "Y") { lblAbout.Visible = true; } else { lblAbout.Visible = false; }
                    gbMenu.Visible = true;
                    lblMenoHide.Visible = true;
                    pbMenu.Visible = false;
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
                
        private void lblMenoHide_Click(object sender, EventArgs e)
        {
            gbMenu.Visible = false;
            pbMenu.Visible = true;

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            gbMenu.Visible = true;
            pbMenu.Visible = false;
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbUnderAddInfo.Visible = true;
        }

        private void lblInformation_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbInformation.Visible = true;
            gbMenu.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbMenu.Visible = true;
        }

        private void lblMediddm_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbMediddm.Visible = true;
            gbMenu.Visible = true;        
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbLoging.Visible = true;
        }

        private void lblPersonal_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbPersonal.Visible = true;
            gbMenu.Visible = true;
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbSetting.Visible = true;
            gbMenu.Visible = true;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            AllGroupBoxVisiableFalse();
            gbHome.Visible = true;
            gbMenu.Visible = true;
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            var obj2 = new DashboardForm();
            obj2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var obj2 = new DashboardForm();
            obj2.ShowDialog();
        }
    }
}
