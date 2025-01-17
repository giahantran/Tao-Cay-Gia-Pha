﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGP
{
    public partial class FormHome : Form
    {
        
        public FormHome()
        {
            InitializeComponent();
        }
        private void btCreateGiaPha_Click(object sender, EventArgs e)
        {
            Add log = new Add();
            log.pnTheHe.Visible = false;
            log.pnThuocGP.Visible = false;
            log.PnXemBaMe.Visible = false;
            log.ShowDialog();
        }
        private void btMauGiaPha_Click(object sender, EventArgs e)
        {
            FormDisplay dispGiaPha = new FormDisplay();
            dispGiaPha.Show();
            dispGiaPha.panel1.Hide();
            dispGiaPha.panel2.Hide();
            dispGiaPha.panel3.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(445, 390);
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.GC.Collect();
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.ShowDialog();
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ: \n17110094@student.hcmute.edu.vn\n17110252@student.hcmute.edu.vn");
        }
    }
}