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
    public partial class DecimalToHexaDecimalForm : Form
    {
        public DecimalToHexaDecimalForm()
        {
            InitializeComponent();
        }

        private void btnHexaConvert_Click(object sender, EventArgs e)
        {
            
            int dec = Convert.ToInt32(txtDecimal.Text.Trim());

            string hex = dec.ToString("X");

            lblHexadecimal.Text = hex;

            string octal = OctalNumber(hex);

            lblOctalNum.Text = octal;

            string binary = BinaryNumber(octal);

            lblBinary.Text = binary;
        }
        
        private string BinaryNumber(string octal)
        {
            string binary = Convert.ToString(Convert.ToInt32(octal,8),2);
            return binary;
        }

        private string OctalNumber(string hex)
        {
            string binary = Convert.ToString(Convert.ToInt32(hex,16),2);
            string octal = Convert.ToString(Convert.ToInt32(binary,2),8);
            return octal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txtString.Text.Trim();

            string binary = StringToBinary(text);

            lblBinary2.Text = binary;

            string hexa = StringToHexa(text);

            lblHexa2.Text = hexa;

            string octal = StringToOctal(text);

            lblOctal2.Text = octal;
        }

        private string StringToOctal(string text)
        {
            StringBuilder octalBuilder = new StringBuilder();

            foreach (char c in text)
            {
                string octal = Convert.ToString(c, 8);
                octalBuilder.Append(octal);
            }

            return octalBuilder.ToString();
        }

        private string StringToHexa(string text)
        {
            StringBuilder hexadecimalBuilder = new StringBuilder();

            foreach (char c in text)
            {
                string hexadecimal = ((int)c).ToString("X2");
                hexadecimalBuilder.Append(hexadecimal);
            }

            return hexadecimalBuilder.ToString();
        }

        static string StringToBinary(string text)
        {
            StringBuilder binaryBuilder = new StringBuilder();

            foreach (char c in text)
            {
                string binary = Convert.ToString(c, 2).PadLeft(8, '0');
                binaryBuilder.Append(binary);
            }

            return binaryBuilder.ToString();
        }

        private void DecimalToHexaDecimalForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;

            dateTimePicker3.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dateTimePicker4.MaxDate = DateTime.Now.AddDays(10);

            //dtpFrom.DisplayDate = DateTime.Now - 1;

            int dtYear = DateTime.Now.Year;
            int dtMonth = DateTime.Now.Month;
            int dtDay = DateTime.Now.Day;

            dateTimePicker5.Value = new DateTime(dtYear, dtMonth, dtDay - 1);

            //dtpFrom.DisplayDate = DateTime.Now.AddDays(-1);

            //dateTimePicker5.Value = DateTime.Today.AddDays(-1);

            dateTimePicker5.MinDate = DateTime.Now.AddDays(-1).Date;
            dateTimePicker5.MaxDate = DateTime.Now.AddDays(-1).Date;
            dateTimePicker5.MaxDate = DateTime.Now.AddDays(-1).Date;

            //dateTimePicker5.Value = DateTime.Now;
            dateTimePicker6.Value = DateTime.Now;
            dateTimePicker7.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
        }
    }
}
