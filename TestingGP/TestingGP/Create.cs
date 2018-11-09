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
    public partial class FormCreate : Form
    {
        private Tree _tree;
        private readonly TreeDrower _drower;
        public FormCreate()
        {
            _tree = new Tree();
            _drower = new TreeDrower();
            InitializeComponent();
        }

        List<string> listItem;
        private void combMenu_Click(object sender, EventArgs e)
        {
            listItem = new List<string>() { "Nhập cây gia phả", "Xem toàn bộ cây gia phả", "Tìm kiếm người", "Xem những người cùng thế hệ", "Thêm người vào gia phả" };
            combMenu.DataSource = listItem;
        }

        
        private Rectangle ResizePanel()
        {
            var size = _drower.GetSize(_tree);
            drawingPanel.Width = size.Width + 2;
            drawingPanel.Height = size.Height + 2;
            return new Rectangle(new Point(0, 0), size);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            _tree = new Tree();
            drawingPanel.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            try
            {
                var value = Int32.Parse(textBox1.Text);
                _tree.AddElement(value);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Wrong value");
            }
            drawingPanel.Refresh();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            var graphics = drawingPanel.CreateGraphics();
            var rectangle = ResizePanel();

            _drower.Draw(graphics, _tree.GetTop(), rectangle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (combMenu.Text == "Xem những người cùng thế hệ")
            {
                Form2 f = new Form2();
                f.Show();

            }
        }

        private void mnuTaoGPCreate_Click(object sender, EventArgs e)
        {
            FormAdd creGiaPha = new FormAdd();
            creGiaPha.Show();
        }
    }
}
