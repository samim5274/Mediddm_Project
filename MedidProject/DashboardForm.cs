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
    public partial class DashboardForm : Form
    {

        List<double> xValue = new List<double>();
        List<double> yValue = new List<double>();

        List<double> x1Value = new List<double>();
        List<double> y1Value = new List<double>();

        List<double> x2Value = new List<double>();
        List<double> y2Value = new List<double>();


        List<double> x3Value = new List<double>();
        List<double> y3Value = new List<double>();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            Chart1Ghaph();
            Chart2Graph();
        }

        private void Chart2Graph()
        {
            chart2.Series["Series1"].Color = Color.Khaki;
            chart2.Series["Series2"].Color = Color.HotPink;
            chart2.Series["Series3"].Color = Color.Indigo;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            x2Value.Add(0);           y2Value.Add(0);

            x2Value.Add(1);            y2Value.Add(5);

            x2Value.Add(2);            y2Value.Add(15);

            x2Value.Add(3);            y2Value.Add(35);

            x2Value.Add(4);            y2Value.Add(20);

            x2Value.Add(5);            y2Value.Add(35);

            //=====================================================

            x1Value.Add(0); y1Value.Add(0);

            x1Value.Add(1); y1Value.Add(15);

            x1Value.Add(2); y1Value.Add(10);

            x1Value.Add(3); y1Value.Add(25);

            x1Value.Add(4); y1Value.Add(25);

            x1Value.Add(5); y1Value.Add(30);

            //============================================================

            x3Value.Add(0); y3Value.Add(0);

            x3Value.Add(1); y3Value.Add(10);

            x3Value.Add(2); y3Value.Add(15);

            x3Value.Add(3); y3Value.Add(25);

            x3Value.Add(4); y3Value.Add(10);

            x3Value.Add(5); y3Value.Add(20);


            chart2.Series["Series1"].Points.DataBindXY(x2Value, y2Value);
            chart2.Series["Series2"].Points.DataBindXY(x1Value, y1Value);
            chart2.Series["Series3"].Points.DataBindXY(x3Value, y3Value);

            chart2.Invalidate();
        }

        private void Chart1Ghaph()
        {
            chart1.Series["Income"].Color = Color.GreenYellow;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            xValue.Add(0);
            yValue.Add(0);

            xValue.Add(1);
            yValue.Add(15);

            xValue.Add(2);
            yValue.Add(10);

            xValue.Add(3);
            yValue.Add(35);

            xValue.Add(4);
            yValue.Add(20);

            xValue.Add(5);
            yValue.Add(20);

            chart1.Series["Income"].Points.DataBindXY(xValue, yValue);

            chart1.Invalidate();
        }
    }
}
