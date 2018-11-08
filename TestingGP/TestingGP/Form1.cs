using System;
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
            FormCreate creGiaPha = new FormCreate();
            creGiaPha.Show();
        }

        private void btMauGiaPha_Click(object sender, EventArgs e)
        {
            FormDisplay dispGiaPha = new FormDisplay();
            dispGiaPha.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Location = new Point(170, 80);
            this.lbGiaPha.Location = new Point(300, 130);
            this.pictureBox2.Location = new Point(477, 308);
            this.pictureBox1.Location = new Point(-25, 92);
            this.label1.Parent = this.pictureBox1;
            this.lbGiaPha.Parent = this.pictureBox1;
            this.pictureBox2.Parent = this.pictureBox1;
            
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
