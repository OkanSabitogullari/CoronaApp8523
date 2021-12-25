using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp8523
{
    public partial class BelirtiTespitForm : Form
    {
        string[] sehirler = new string[3]
        {
            "Ankara",
            "İstanbul",
            "İzmir"
        };
        public BelirtiTespitForm()
        {
            InitializeComponent();
        }

        private void BelirtiTespitForm_Load(object sender, EventArgs e)
        {
            //foreach (string sehir in sehirler)
            //{
            //    ddlSehir.Items.Add(sehir);
            //}
            ddlSehir.Items.AddRange(sehirler);
            ddlSehir.SelectedIndex = 0;
            dtpTarih.Value = DateTime.Now;
        }

        private void bTespit_Click(object sender, EventArgs e)
        {
            TespitEt();

        }

        private void TespitEt()
        {
            if (rbKadin.Checked)
            {
                tbSonuc.Text = "Bayan";
            }
            else
            {
                tbSonuc.Text = "Bay";
            }
            //tbSonuc.Text = tbSonuc.Text + tbAd.Text + " " + tbSoyad.Text;
            tbSonuc.Text += tbAd.Text + " " + tbSoyad.Text + "\r\n";
            tbSonuc.Text += "Şehriniz :" + ddlSehir.Text + "\r\n";
            tbSonuc.Text += "Yaşınız :" + nudYas.Value + "\r\n";
            tbSonuc.Text += "Test Tarihi :" + dtpTarih.Value.ToString("dd.MM.yyyy", new CultureInfo("tr")) + "\r\n";

            if (cbAtes.Checked)
            {
                tbSonuc.Text += "Koronasınız";
            }
            else
            {
                if (cbBogaz.Checked && cbOksuruk.Checked)
                {
                    tbSonuc.Text += "Koronasınız";
                }
                else
                {
                    tbSonuc.Text += "Korona değilsiniz";
                }
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAd.Text = "";
            tbSoyad.Clear();
            ddlSehir.SelectedIndex = 0;
            nudYas.Value = 50;
            rbKadin.Checked = true;
            dtpTarih.Value = DateTime.Now;
            cbAtes.Checked = false;
            cbBogaz.Checked = false;
            cbOksuruk.Checked = false;
            tbSonuc.Text = "";
        }

        private void cbAtes_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void cbOksuruk_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void cbBogaz_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void tbSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
