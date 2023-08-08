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
    public partial class DayAndDayDepositAndExpensesReport : Form
    {
        public DayAndDayDepositAndExpensesReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var obj = new Manager();
            var list = obj.GetDayWiseDepositAndExpensesReport(SD,ED);
            dgvDepositAndExpensesReport.DataSource = list;

            lblTotalDeposit.Text = "0";
            for (int i = 0; i < dgvDepositAndExpensesReport.Rows.Count; i++)
            {
                lblTotalDeposit.Text = Convert.ToString(double.Parse(lblTotalDeposit.Text) + double.Parse(dgvDepositAndExpensesReport.Rows[i].Cells[4].Value.ToString()));
            }

            lblTotalExpenses.Text = "0";
            for (int i = 0; i < dgvDepositAndExpensesReport.Rows.Count; i++)
            {
                lblTotalExpenses.Text = Convert.ToString(double.Parse(lblTotalExpenses.Text) + double.Parse(dgvDepositAndExpensesReport.Rows[i].Cells[5].Value.ToString()));
            }

            lblCashOnHand.Text = (float.Parse(lblTotalDeposit.Text) - float.Parse(lblTotalExpenses.Text)).ToString();

        }

        private void DayAndDayDepositAndExpensesReport_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
        }
    }
}
