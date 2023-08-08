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
    public partial class DayWithReceiverAndGiverReportForm : Form
    {
        public DayWithReceiverAndGiverReportForm()
        {
            InitializeComponent();
        }

        private void DayWithReceiverAndGiverReportForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillGiverName();
            FillReciverName();
        }

        private void FillReciverName()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxReciverName.DisplayMember = "S_Name";
            cbxReciverName.ValueMember = "Id";
            cbxReciverName.DataSource = list;
        }

        private void FillGiverName()
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
            var RN = Convert.ToInt32(cbxReciverName.SelectedValue);

            var obj = new Manager();
            var list = obj.GetDayReceiverGiverReport(SD, ED, GN, RN);
            dgvDayReceiverGiverReportShow.DataSource = list;

            lblTotal.Text = "0";
            for (int i = 0; i < dgvDayReceiverGiverReportShow.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dgvDayReceiverGiverReportShow.Rows[i].Cells[7].Value.ToString()));
            }
        }
    }
}
