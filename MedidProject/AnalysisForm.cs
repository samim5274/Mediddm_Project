using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedidProject
{
    public partial class AnalysisForm : Form
    {

        List<DateTime> xTValue = new List<DateTime>();
        List<double> yValue = new List<double>();

        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.AddDays(-1).Date;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(-1).Date;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(-1).Date;

            dateTimePicker2.MinDate = DateTime.Now.AddDays(-2).Date;
            dateTimePicker2.MaxDate = DateTime.Now.AddDays(-2).Date;
            dateTimePicker2.MaxDate = DateTime.Now.AddDays(-2).Date;

            dateTimePicker3.MinDate = DateTime.Now.AddDays(-3).Date;
            dateTimePicker3.MaxDate = DateTime.Now.AddDays(-3).Date;
            dateTimePicker3.MaxDate = DateTime.Now.AddDays(-3).Date;

            dateTimePicker4.MinDate = DateTime.Now.AddDays(-4).Date;
            dateTimePicker4.MaxDate = DateTime.Now.AddDays(-4).Date;
            dateTimePicker4.MaxDate = DateTime.Now.AddDays(-4).Date;

            dateTimePicker5.MinDate = DateTime.Now.AddDays(-5).Date;
            dateTimePicker5.MaxDate = DateTime.Now.AddDays(-5).Date;
            dateTimePicker5.MaxDate = DateTime.Now.AddDays(-5).Date;

            dateTimePicker6.MinDate = DateTime.Now.AddDays(-6).Date;
            dateTimePicker6.MaxDate = DateTime.Now.AddDays(-6).Date;
            dateTimePicker6.MaxDate = DateTime.Now.AddDays(-6).Date;

            dateTimePicker7.MinDate = DateTime.Now.AddDays(-7).Date;
            dateTimePicker7.MaxDate = DateTime.Now.AddDays(-7).Date;
            dateTimePicker7.MaxDate = DateTime.Now.AddDays(-7).Date;

            var d1 = dateTimePicker1.Value;
            var d2 = dateTimePicker2.Value;
            var d3 = dateTimePicker3.Value;
            var d4 = dateTimePicker4.Value;
            var d5 = dateTimePicker5.Value;
            var d6 = dateTimePicker6.Value;
            var d7 = dateTimePicker7.Value;

            var v1 = Convert.ToInt32(lblType.Text.Trim());
            var v2 = Convert.ToInt32(lblType.Text.Trim());
            var v3 = Convert.ToInt32(lblType.Text.Trim());
            var v4 = Convert.ToInt32(lblType.Text.Trim());
            var v5 = Convert.ToInt32(lblType.Text.Trim());
            var v6 = Convert.ToInt32(lblType.Text.Trim());
            var v7 = Convert.ToInt32(lblType.Text.Trim());



            var obj = new Manager();
            var list = obj.GetAllValue(d1, v1);
            dataGridView1.DataSource = list;

            var obj2 = new Manager();
            var list2 = obj2.GetAllValue2(d2, v2);
            dataGridView2.DataSource = list2;

            var obj3 = new Manager();
            var list3 = obj3.GetAllValue3(d3, v3);
            dataGridView3.DataSource = list3;

            var obj4 = new Manager();
            var list4 = obj4.GetAllValue4(d4, v4);
            dataGridView4.DataSource = list4;

            var obj5 = new Manager();
            var list5 = obj5.GetAllValue5(d5, v5);
            dataGridView5.DataSource = list5;

            var obj6 = new Manager();
            var list6 = obj6.GetAllValue6(d6, v6);
            dataGridView6.DataSource = list6;

            var obj7 = new Manager();
            var list7 = obj7.GetAllValue7(d7, v7);
            dataGridView7.DataSource = list7;

            label1.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }

            label2.Text = "0";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }

            label3.Text = "0";
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                label3.Text = Convert.ToString(double.Parse(label3.Text) + double.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString()));
            }

            label4.Text = "0";
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                label4.Text = Convert.ToString(double.Parse(label4.Text) + double.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString()));
            }

            label5.Text = "0";
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                label5.Text = Convert.ToString(double.Parse(label5.Text) + double.Parse(dataGridView5.Rows[i].Cells[2].Value.ToString()));
            }

            label6.Text = "0";
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {
                label6.Text = Convert.ToString(double.Parse(label6.Text) + double.Parse(dataGridView6.Rows[i].Cells[2].Value.ToString()));
            }

            label7.Text = "0";
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                label7.Text = Convert.ToString(double.Parse(label7.Text) + double.Parse(dataGridView7.Rows[i].Cells[2].Value.ToString()));
            }


            var y1 = Convert.ToInt32(label1.Text.Trim());
            var y2 = Convert.ToInt32(label2.Text.Trim());
            var y3 = Convert.ToInt32(label3.Text.Trim());
            var y4 = Convert.ToInt32(label4.Text.Trim());
            var y5 = Convert.ToInt32(label5.Text.Trim());
            var y6 = Convert.ToInt32(label6.Text.Trim());
            var y7 = Convert.ToInt32(label7.Text.Trim());

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            chart1.Series["Income"].Color = Color.Turquoise;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yy";
            chart1.Series["Income"].Points.DataBindXY(xTValue, yValue);

            xTValue.Add(d1);
            yValue.Add(y1);

            xTValue.Add(d2);
            yValue.Add(y2);

            xTValue.Add(d3);
            yValue.Add(y3);

            xTValue.Add(d4);
            yValue.Add(y4);

            xTValue.Add(d5);
            yValue.Add(y5);

            xTValue.Add(d6);
            yValue.Add(y6);

            xTValue.Add(d7);
            yValue.Add(y7);

            chart1.Series["Income"].Points.DataBindXY(xTValue, yValue);
            chart1.Invalidate();

            chart2.Series["Series1"].Points.AddXY(d1,y1);
            chart2.Series["Series1"].Points.AddXY(d2,y2);
            chart2.Series["Series1"].Points.AddXY(d3,y3);
            chart2.Series["Series1"].Points.AddXY(d4,y4);
            chart2.Series["Series1"].Points.AddXY(d4,y5);
            chart2.Series["Series1"].Points.AddXY(d5,y6);
            chart2.Series["Series1"].Points.AddXY(d7,y7);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
