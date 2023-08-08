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
    public partial class TransectionReportForm : Form
    {
        public TransectionReportForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransectionReportForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillGiverName();
            FillReciverName();
            FillPurpose();
        }

        private void FillGiverName()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxGiverName.DisplayMember = "S_Name";
            cbxGiverName.ValueMember = "Id";
            cbxGiverName.DataSource = list;
        }

        private void FillReciverName()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxReciverName.DisplayMember = "S_Name";
            cbxReciverName.ValueMember = "Id";
            cbxReciverName.DataSource = list;
        }

        private void FillPurpose()
        {
            var obj = new Manager();
            var list = obj.GettAllPurpose();
            cbxPurpose.DisplayMember = "P_Name";
            cbxPurpose.ValueMember = "P_Id";
            cbxPurpose.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var GN = Convert.ToInt32(cbxGiverName.SelectedValue);
            var PN = Convert.ToInt32(cbxPurpose.SelectedValue);
            var RN = Convert.ToInt32(cbxReciverName.SelectedValue);

            var obj = new Manager();
            var list = obj.GetTransectionReport(SD,ED,GN,PN,RN);
            dgvTransectionReportShow.DataSource = list;
        }
    }
}
