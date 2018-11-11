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
            listItem = new List<string>() {"Xuất thế hệ con cháu của một người", "Xem những người cùng thế hệ", "Xem thông tin của một người" };
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
                f.pntimnguoitheoten.Hide(); //ẩn đi những panel khác
            }
            if (combMenu.Text == "Xem thông tin của một người")
            {
                Form2 f = new Form2();
                f.Show();
                f.pnxemnguoicungthehe.Hide();   //ẩn đi những panel khác

            }
        }
        private void mnuTaoGPCreate_Click(object sender, EventArgs e)
        {
            FormAdd creGiaPha = new FormAdd();
            creGiaPha.Show();
        }
        
    }
}
