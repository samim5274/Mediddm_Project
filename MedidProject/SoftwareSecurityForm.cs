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
    public partial class SoftwareSecurityForm : Form
    {
        public SoftwareSecurityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string to hexadecimal convert
            string text = textBox8.Text.Trim();
            String hexa = StringToHexa(text);
            label3.Text = hexa;
            //hexadecimal to string covnert
            string hexString = hexa;             
            byte[] bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }            
            string result = Encoding.UTF8.GetString(bytes);
            label4.Text = result; 
        }

        private string StringToHexa(string text)
        {
            StringBuilder hexaDecimalBuilder = new StringBuilder();
            foreach (char c in text)
            {
                string hexadecimal = ((int)c).ToString("X2");
                hexaDecimalBuilder.Append(hexadecimal);
            }
            return hexaDecimalBuilder.ToString();
        }

        private void SoftwareSecurityForm_Load(object sender, EventArgs e)
        {
            var db = new MEDIDDMEntities();

            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.Text.Trim()).FirstOrDefault();

            var dt1 = DateTime.Now;
            var dt2 = Convert.ToDateTime(select.Validiti);
            if (dt1 < dt2)
            {                
                lblGenaretValue.Text = "Great!";
            }
            else if (dt1 > dt2)
            {
                lblGenaretValue.Text = "No thanks!";
            }

            SecurityMessage();

        }

        private void SecurityMessage()
        {
            var db = new MEDIDDMEntities();

            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.Text.Trim()).FirstOrDefault();
            
            var dt2 = Convert.ToDateTime(select.Validiti);

            var dt3 = dt2 - DateTime.Now ;
            //MessageBox.Show(""+dt9.ToString()+"");
            lblDate.Text = dt3.ToString("dd");

            switch (lblDate.Text)
            {
                case "00":
                    MessageBox.Show("Your license is already expired. Please update your license. Thank you!");
                    break;
                case "01":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "02":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "03":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "04":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "05":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "06":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
                case "07":
                    MessageBox.Show("Your license will be expired after " + dt3.ToString("dd") + " days. Please update your license. Thank you!");
                    break;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var db = new MEDIDDMEntities();

            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.Text.Trim()).FirstOrDefault();
            dateTimePicker1.Value = Convert.ToDateTime(select.Validiti);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var db2 = new MEDIDDMEntities();
            var select2 = db2.SecurityTables.Where(a => a.Id.ToString() == lblId.Text.Trim()).FirstOrDefault();
            select2.Validiti = Convert.ToDateTime(label4.Text);
            db2.SaveChanges();
        }
    }
}
