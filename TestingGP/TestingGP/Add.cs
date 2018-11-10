using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TestingGP
{
    public partial class FormAdd : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C99VFUB\GIAHAN;Initial Catalog=DL_GIAPHA;Integrated Security=True"); //Hân
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GIAPHA;Integrated Security=True"); //Văn
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RRRHOP4;Initial Catalog=Genealogy;Integrated Security=True"); //Na
        SqlDataAdapter daGiaPha = null;
        DataTable dtGiaPha = null;

        public void KetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from UserGP", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dgvGiaPha.DataSource = dtGiaPha;
                dgvGiaPha.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvGiaPha.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dgvGiaPha.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Disconnect()
        {
            conn.Close(); //Đóng kết nối
            conn.Dispose(); //Giải phóng tài nguyên
            conn = null; //Hủy đối tượng
        }
        private void GetData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From UserGP";
            daGiaPha.SelectCommand = cmd;
            daGiaPha.Fill(dtGiaPha);
            dgvGiaPha.DataSource = dtGiaPha;
        }
        public FormAdd()
        {
            InitializeComponent();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //
        public class GIAPHA
        {
            public int keyNode;
            public int iD, theHe;
            public string hoTen, cha, me, tenVoChong, tenCon;
            public string gioiTinh, thuocGP; //true = nam, true = có trong gia phả
            public string namSinh, namMat;
            public string noiSinh, ngheNghiep, ghiChu;
        }
        public class BinaryTree
        {
            private GIAPHA info;
            private BinaryTree pLeft;
            private BinaryTree pRight;
            public BinaryTree(int key, GIAPHA gp)
            {
                info = gp;
                info.keyNode = key;
                pLeft = pRight = null;
            }
            public BinaryTree pleft
            {
                get { return pLeft; }
                set { pLeft = value; }
            }
            public BinaryTree pright
            {
                get { return pRight; }
                set { pRight = value; }
            }
            public GIAPHA inFO
            {
                get { return info; }
                set { info = value; }
            }
            public void AddNode(int key, GIAPHA gp)
            {
                if (key == info.keyNode)
                {
                    MessageBox.Show("Thông tin đã có trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (key < info.keyNode)
                {
                    if (pLeft == null) pLeft = new BinaryTree(key, gp);
                    else pLeft.AddNode(key, gp);
                }
                else
                {
                    if (pRight == null) pRight = new BinaryTree(key, gp);
                    else pRight.AddNode(key, gp);
                }
            }
        }
        public class BTree : FormAdd
        {
            public BinaryTree root;
            public BTree()
            {
                root = null;
            }
            public void InsertNode(int key, GIAPHA gp)
            {
                if (root == null)
                    root = new BinaryTree(key, gp);
                else root.AddNode(key, gp);
            }
            public void CreateGP(GIAPHA gp)
            {
                gp.iD = Convert.ToInt32(combMaTV.Text);
                gp.theHe = Convert.ToInt32(combTheHe.Text);
                gp.hoTen = txtbHoTen.Text;
                gp.cha = txtBHotenCha.Text;
                gp.me = txtBHoTenMe.Text;
                gp.tenVoChong = txtBHoTenVC.Text;
                gp.tenCon = txtBHoTenCon.Text;
                if (checkBGioiTinh.Checked == true) gp.gioiTinh = "Nam";
                else gp.gioiTinh = "Nữ";
                if (checkBThuocGP.Checked == true) gp.thuocGP = "Có";
                else gp.thuocGP = "Không";
                gp.namSinh = DateTime.Parse(dateNgaySinh.Text).ToString();
                gp.namMat = DateTime.Parse(dateNgayMat.Text).ToString();
                gp.ngheNghiep = txtBNgheNghiep.Text;
                gp.noiSinh = txtBQueQuan.Text;
                gp.ghiChu = txtBGhiChu.Text;
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowAdd.Visible = false;
            KetNoi();
        }



        /*
        private void ShowTreeView()
        {
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                treeViewShowAdd.Nodes.Add(dt.Rows[i].Cells[3].Value.ToString());
                if (i % 2 == 0)
                {
                    //addChildNode(1, dt.Rows[i].Cells[3].Value.ToString());
                }
            }
            treeViewShowAdd.Nodes.Add(dt.Rows[1].Cells[4].Value.ToString());
            addChildNode(1, dt.Rows[2].Cells[4].Value.ToString());
            addChildNode(1, dt.Rows[3].Cells[4].Value.ToString());


            //  addChildNodeMMore();
            //treeViewShow.Nodes.Add(dt.Rows[0].Cells[3].Value.ToString());
            //treeViewShow.Nodes.Add(dt.Rows[1].Cells[3].Value.ToString());

            //TreeNode parentNode = treeViewShow.SelectedNode ?? treeViewShow.Nodes[0];
            //List<TreeNode> Nodes = new List<TreeNode>();
            //AddChild(Nodes, parentNode);

        }
        private void dequy(int i, int j)
        {
            for (int i1 = i; i1 <= j; i1++)
            {

            }
        }
        private void AddChild(List<TreeNode> Nodes, TreeNode Node)
        {
            foreach (TreeNode thisNode in Node.Nodes)
            {
                Nodes.Add(thisNode);
                AddChild(Nodes, thisNode);
            }
        }
        private void addChildNode(int index, string str)
        {
            var childNode = str;
            if (!string.IsNullOrEmpty(childNode))
            {
                TreeNode parentNode = treeViewShowAdd.SelectedNode ?? treeViewShowAdd.Nodes[index];
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(childNode);
                    treeViewShowAdd.ExpandAll();
                }
            }
        }
        private void addChildNodeMMore()
        {
            var childNode = "NA xam";
            if (!string.IsNullOrEmpty(childNode))
            {
                TreeNode parentNode = treeViewShowAdd.SelectedNode ?? treeViewShowAdd.Nodes[0].Nodes[0];
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(childNode);
                    treeViewShowAdd.ExpandAll();
                }
            }
        }
        private void Add_Load(object sender, EventArgs e)
        {
            ShowTreeView();
        }
        */
    }
}