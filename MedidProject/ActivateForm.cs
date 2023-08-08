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
    public partial class ActivateForm : Form
    {
        public ActivateForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnActive_Click(object sender, EventArgs e)
        {
            var db = new MEDIDDMEntities();
            int lblId = 1;
            var select = db.SecurityTables.Where(a => a.Id.ToString() == lblId.ToString()).FirstOrDefault();
            if (textBox1.Text == "")
            {
                MessageBox.Show(@"Please input the license key and try again later. Thank you.", "Input Emtry!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                textBox1.Focus();
            }
            else
            {
                try
                {
                    string hexString = textBox1.Text;
                    byte[] bytes = new byte[hexString.Length / 2];
                    for (int i = 0; i < hexString.Length; i += 2)
                    {
                        bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
                    }
                    string result = Encoding.UTF8.GetString(bytes);
                    string re = result;
                    if (re == "2023-06-07" || re == "2023-12-07" || re == "2024-06-07" || re == "2024-12-07" || re == "2025-06-07" ||
                    re == "2025-12-07" || re == "2026-06-07" || re == "2026-12-07" || re == "2027-06-07" || re == "2027-12-07" ||
                    re == "2028-06-07" || re == "2028-12-07" || re == "2029-06-07" || re == "2029-12-07" || re == "2030-06-07" || re == "2030-12-07")
                    {
                        select.Validiti = Convert.ToDateTime(result);
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"The product keyword you entered is incorrect. Thank you.", "Wrong Product Key!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
