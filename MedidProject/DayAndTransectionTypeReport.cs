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
    public partial class DayAndTransectionTypeReport : Form
    {
        public DayAndTransectionTypeReport()
        {
            InitializeComponent();
        }

        private void chkDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeposit.Checked)
            {
                chkExpenses.Checked = false;
                lblType.Text = "0";
            }
            else
            {
                chkDeposit.Checked = false;
                lblType.Text = "00";
            }
        }

        private void chkExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpenses.Checked)
            {
                chkDeposit.Checked = false;
                lblType.Text = "1";
            }
            else
            {
                chkExpenses.Checked = false;
                lblType.Text = "00";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var TT = Convert.ToInt32(lblType.Text.Trim());
            if (lblType.Text=="00")
            {
                MessageBox.Show(@"Please select the transection type and try again. Thank you!", "Search Erorr!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                dgvTransectionTypeReport.DataSource = string.Empty;
                lblTotalDeposit.Text = "00";
                lblTotalExpenses.Text = "00";
            }
            else
            {
                var obj = new Manager();
                var list = obj.GetTransectionTypeReport(SD, ED, TT);
                dgvTransectionTypeReport.DataSource = list;
                
                lblTotalDeposit.Text = "0";
                for (int i = 0; i < dgvTransectionTypeReport.Rows.Count; i++)
                {
                    lblTotalDeposit.Text = Convert.ToString(double.Parse(lblTotalDeposit.Text) + double.Parse(dgvTransectionTypeReport.Rows[i].Cells[4].Value.ToString()));
                }

                lblTotalExpenses.Text = "0";
                for (int i = 0; i < dgvTransectionTypeReport.Rows.Count; i++)
                {
                    lblTotalExpenses.Text = Convert.ToString(double.Parse(lblTotalExpenses.Text) + double.Parse(dgvTransectionTypeReport.Rows[i].Cells[5].Value.ToString()));
                }
                
            }            
        }

        private void DayAndTransectionTypeReport_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
    }
}
