﻿using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_windows
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBarAdv1.Value < 100)

                this.progressBarAdv1.Value++;

            else

                this.progressBarAdv1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
