﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int dogru, yanlıs;
            double netDogru;

            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlıs= Convert.ToInt32(cmbYanıs.Text);

            netDogru = dogru - yanlıs / 4.0;

            lblNet.Text = "toplam net dogru" + netDogru.ToString();

        }
    }
}
