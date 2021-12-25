using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp8523
{
    public partial class YuzdeTespitForm : Form
    {
        public YuzdeTespitForm()
        {
            InitializeComponent();
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAdSoyad.Text = "";
            cbAtes.Checked = false;
            cbBogaz.Checked = false;
            cbOksuruk.Checked = false;
            lbSonuc.Items.Clear();
            gbRapor.Visible = false;
        }

        private void bTespitEt_Click(object sender, EventArgs e)
        {
            int yuzde = 0;
            if (cbAtes.Checked)
            {
                yuzde += 70;
            }
            if (cbBogaz.Checked)
            {
                yuzde += 10;
            }
            if (cbOksuruk.Checked)
            {
                yuzde += 20;
            }
            lbSonuc.Items.Add("Sayın " + tbAdSoyad.Text + " , %" + yuzde + " ihtimalle koronasınız.");

        }

        private void bRapor_Click(object sender, EventArgs e)
        {
            rtbRapor.Text = "";
            if (lbSonuc.Items.Count > 0)
            {
               foreach (var item in lbSonuc.Items)
               {
                rtbRapor.Text += item + "\r\n";
               }
            }
            gbRapor.Visible = true;
        }
    }
}
