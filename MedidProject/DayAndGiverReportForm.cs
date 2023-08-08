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
    public partial class DayAndGiverReportForm : Form
    {
        public DayAndGiverReportForm()
        {
            InitializeComponent();
        }

        private void DayAndGiverReportForm_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            FillGiver();
        }

        private void FillGiver()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxGiverName.DisplayMember = "S_Name";
            cbxGiverName.ValueMember = "Id";
            cbxGiverName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var GN = Convert.ToInt32(cbxGiverName.SelectedValue);
            var obj = new Manager();
            var list = obj.GetGiverReport(SD, ED, GN);
            dgvGiverReportShow.DataSource = list;

            lblTotal.Text = "0";
            for (int i = 0; i < dgvGiverReportShow.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dgvGiverReportShow.Rows[i].Cells[7].Value.ToString()));
            }
        }
    }
}
