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
    public partial class DayAndPurposeReportForm : Form
    {
        public DayAndPurposeReportForm()
        {
            InitializeComponent();
        }

        private void DayAndPurposeReportForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillPurpose();
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
            var PN = Convert.ToInt32(cbxPurpose.SelectedValue);
            var obj = new Manager();
            var list = obj.GetPurposeReport(SD,ED,PN);
            dgvPurposeReportShow.DataSource = list;

            lblTotal.Text = "0";
            for (int i = 0; i < dgvPurposeReportShow.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dgvPurposeReportShow.Rows[i].Cells[7].Value.ToString()));
            }
        }
    }
}
