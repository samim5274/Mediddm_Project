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
    public partial class Student_Information : Form
    {
        public Student_Information()
        {
            InitializeComponent();
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            GetGender();
            GetDepartment();
            ClearAll();
            FillGrid();
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GetStudentInfo();
            dgvShowStudentInfo.DataSource = list;
        }

        private void ClearAll()
        {
            txtId.Text = String.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtDiscription.Text = string.Empty;
            cbxDepartment.Text = string.Empty;
            cbxGender.Text = string.Empty;
            txtSearch.Text = string.Empty;
            //dgvStudentInfo.DataSource = string.Empty;
        }

        private void GetDepartment()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "G_Name";
            cbxGender.ValueMember = "G_Id";
            cbxGender.DataSource = list;
        }

        private void GetGender()
        {
            var obj = new Manager();
            var list = obj.GetAllDepartment();
            cbxDepartment.DisplayMember = "Dep_Name";
            cbxDepartment.ValueMember = "Dep_Id";
            cbxDepartment.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                SaveInfo();
                ShowDataGridView();
                ClearAll();
            }
            else if (btnSave.Text=="Edit")
            {
                EditInfo();
                ShowDataGridView();
                ClearAll();
            }
        }

        private void EditInfo()
        {
            var db = new MEDIDDMEntities();
            var selector = db.StudentInfoes.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();

            selector.S_Id = Convert.ToInt32(txtId.Text.Trim());
            selector.S_Name = txtName.Text.Trim();
            selector.S_GenderId = Convert.ToInt32(cbxGender.SelectedValue);
            selector.S_DepId = Convert.ToInt32(cbxDepartment.SelectedValue);
            selector.S_Address = txtAddress.Text.Trim();
            selector.S_Phonse = Convert.ToInt32(txtPhone.Text.Trim());
            selector.S_DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
            selector.S_Discription = txtDiscription.Text.Trim();

            db.SaveChanges();
            btnSave.Text = "Save";
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ShowDataGridView()
        {
            var obj = new Manager();
            var list = obj.GetStudentInfo();
            dgvShowStudentInfo.DataSource = list;
        }

        private void SaveInfo()
        {
            var db = new MEDIDDMEntities();
            var tb = new StudentInfo();

            tb.S_Id = Convert.ToInt32(txtId.Text.Trim());
            tb.S_Name = txtName.Text.Trim();
            tb.S_GenderId = Convert.ToInt32(cbxGender.SelectedValue);
            tb.S_DepId = Convert.ToInt32(cbxDepartment.SelectedValue);
            tb.S_Address = txtAddress.Text.Trim();
            tb.S_Phonse = Convert.ToInt32(txtPhone.Text.Trim());
            tb.S_DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
            tb.S_Discription = txtDiscription.Text.Trim();

            db.StudentInfoes.Add(tb);
            db.SaveChanges();
            MessageBox.Show(@"Student add successfully.","Save info",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MEDIDDMEntities();
                var selector = db.StudentInfoes.Where(a=>a.Id.ToString()==txtSearch.Text).FirstOrDefault();

                txtId.Text = selector.S_Id.ToString();
                txtName.Text = selector.S_Name;
                cbxGender.SelectedValue = selector.S_GenderId;
                cbxDepartment.SelectedValue = selector.S_DepId;
                txtAddress.Text = selector.S_Address;
                txtPhone.Text = selector.S_Phonse.ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(selector.S_DateOfBirth);
                txtDiscription.Text = selector.S_Discription;

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Text = "Edit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSearch.Focus();
                ClearAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text=="")
            {
                btnSave.Enabled = false;
            }
            else if (txtId.Text !=null)
            {
                btnSave.Enabled = true; 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
