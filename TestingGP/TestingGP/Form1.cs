using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://github.com/ysnna/van

namespace TestingGP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCreateGiaPha_Click(object sender, EventArgs e)
        {
            Create creGiaPha = new Create();
            creGiaPha.Show();
        }

        private void btMauGiaPha_Click(object sender, EventArgs e)
        {
            Display dispGiaPha = new Display();
            dispGiaPha.Show();
        }


    }
}
