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
    public partial class DayAndNameReport : Form
    {
        public DayAndNameReport()
        {
            InitializeComponent();
        }

        private void cbxUserName_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillUserName();
        }

        private void FillUserName()
        {
            var obj = new Manager();
            var list = obj.GetUserStudent();
            cbxName.DisplayMember = "FirstName";
            cbxName.ValueMember = "Id";
            cbxName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var UN = Convert.ToInt32(cbxName.SelectedValue);
            var obj = new Manager();
            var list = obj.GetDayAndNameWiseReport(SD,ED,UN);
            dgvDayAndNameReport.DataSource = list;

            lblTotalDeposit.Text = "0";
            for (int i = 0; i < dgvDayAndNameReport.Rows.Count; i++)
            {
                lblTotalDeposit.Text = Convert.ToString(double.Parse(lblTotalDeposit.Text) + double.Parse(dgvDayAndNameReport.Rows[i].Cells[4].Value.ToString()));
            }

            lblTotalExpenses.Text = "0";
            for (int i = 0; i < dgvDayAndNameReport.Rows.Count; i++)
            {
                lblTotalExpenses.Text = Convert.ToString(double.Parse(lblTotalExpenses.Text) + double.Parse(dgvDayAndNameReport.Rows[i].Cells[5].Value.ToString()));
            }


            lblCashOnHand.Text = (float.Parse(lblTotalDeposit.Text) - float.Parse(lblTotalExpenses.Text)).ToString();

        }
    }
}
