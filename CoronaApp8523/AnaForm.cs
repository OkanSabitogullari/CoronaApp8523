﻿using System;
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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm form = new YardimForm();
            form.Show();
        }

        private void belirtiTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BelirtiTespitForm form = new BelirtiTespitForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}