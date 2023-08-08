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
    public partial class DayAndReceiverReportForm : Form
    {
        public DayAndReceiverReportForm()
        {
            InitializeComponent();
        }

        private void DayAndReceiverReportForm_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            GetReciverName();
        }

        private void GetReciverName()
        {
            var obj = new Manager();
            var list = obj.GetAllStudent();
            cbxReciverName.DisplayMember = "S_Name";
            cbxReciverName.ValueMember = "Id";
            cbxReciverName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var RN = Convert.ToInt32(cbxReciverName.SelectedValue);
            var obj = new Manager();
            var list = obj.GetReceiverReport(SD, ED, RN);
            dgvReceiverReportShow.DataSource = list;

            lblTotal.Text = "0";
            for (int i = 0; i < dgvReceiverReportShow.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dgvReceiverReportShow.Rows[i].Cells[7].Value.ToString()));
            }
        }
    }
}
