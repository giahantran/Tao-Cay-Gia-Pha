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

namespace TestingGP
{
    public partial class Add : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C99VFUB\GIAHAN;Initial Catalog=DL_GIAPHA;Integrated Security=True"); //Hân
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GIAPHA;Integrated Security=True"); //Văn
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RRRHOP4;Initial Catalog=Genealogy;Integrated Security=True"); //Na
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
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.dgvGiaPha.Location = new Point(360, 71);
            this.treeViewShowAdd.Location = new Point(360, 71);
            dgvGiaPha.Visible = true;
            treeViewShowAdd.Visible = false;
            for (int i = 1; i <= 1000; i++)
            {
                cbMaTV.Items.Add(i).ToString();
                cbThehe.Items.Add(i).ToString();
            }
            KetNoi();
        }
        public void CreateGP(GIAPHA gp)
        {
            gp.iD = Convert.ToInt32(cbMaTV.Text);
            gp.theHe = Convert.ToInt32(cbThehe.Text);
            gp.hoTen = txtHoten.Text;
            gp.cha = txtHotenCha.Text;
            gp.me = txtHotenMe.Text;
            gp.tenVoChong = txtTenVoChong.Text;
            gp.tenCon = txtHotenCon.Text;
            if (chbGioiTinh.Checked == true) gp.gioiTinh = "Nam";
            else gp.gioiTinh = "Nữ";
            if (chbThuocGP.Checked == true) gp.thuocGP = "Có";
            else gp.thuocGP = "Không";
            gp.namSinh = DateTime.Parse(dateNgaySinh.Text).ToString();
            gp.namMat = DateTime.Parse(dateNgayMat.Text).ToString();
            gp.ngheNghiep = txtNgheNghiep.Text;
            gp.noiSinh = txtQueQuan.Text;
            gp.ghiChu = txtGhiChu.Text;
        }
        public void AddToSQL(GIAPHA gp)
        {
            DataRow row = dtGiaPha.NewRow();
            row["KeyNode"] = gp.keyNode;
            row["ID"] = gp.iD;
            row["Thếhệ"] = gp.theHe;
            row["ThuộcGiaPhả"] = gp.thuocGP;
            row["Họtên"] = gp.hoTen;
            dtGiaPha.Rows.Add(row);
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandType = CommandType.Text;
            cmdAdd.CommandText = @"Insert into UserGP (KeyNode, ID, Thếhệ, ThuộcGiaPhả, Họtên) Values (@KeyNode, @ID, @Thếhệ, @ThuộcGiaPhả, @Họtên)";
            cmdAdd.Parameters.Add("@KeyNode", SqlDbType.Int, 5, "KeyNode");
            cmdAdd.Parameters.Add("@ID", SqlDbType.Int, 5, "ID");
            cmdAdd.Parameters.Add("@Thếhệ", SqlDbType.Int, 5, "Thếhệ");
            cmdAdd.Parameters.Add("@ThuộcGiaPhả", SqlDbType.NVarChar, 10, "ThuộcGiaPhả");
            cmdAdd.Parameters.Add("@Họtên", SqlDbType.NVarChar, 50, "Họtên");
            daGiaPha.InsertCommand = cmdAdd;
            daGiaPha.Update(dtGiaPha);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Phần Cấu trúc
        public class GIAPHA
        {
            public int keyNode;
            public int iD, theHe;
            public string hoTen, cha, me, tenVoChong, tenCon;
            public string gioiTinh, thuocGP; //true = nam, true = có trong gia phả
            public string namSinh, namMat;
            public string noiSinh, ngheNghiep, ghiChu;
        }
        public class Node
        {
            private GIAPHA info;
            private Node pLeft;
            private Node pRight;
            public Node(int key, GIAPHA gp)
            {
                info = gp;
                info.keyNode = key;
                pLeft = pRight = null;
            }
            public Node pleft
            {
                get { return pLeft; }
                set { pLeft = value; }
            }
            public Node pright
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
                    if (pLeft == null) pLeft = new Node(key, gp);
                    else pLeft.AddNode(key, gp);
                }
                else
                {
                    if (pRight == null) pRight = new Node(key, gp);
                    else pRight.AddNode(key, gp);
                }
            }
        }
        public class BTree
        {
            public Node root;
            public BTree()
            {
                root = null;
            }
            public void InsertNode(int key, GIAPHA gp)
            {
                if (root == null)
                    root = new Node(key, gp);
                else root.AddNode(key, gp);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BTree tree = new BTree();
            int key;
            Random random = new Random();
            key = random.Next(100);
            GIAPHA gp = new GIAPHA();
            CreateGP(gp);
            tree.InsertNode(key, gp);
            AddToSQL(gp);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            int r = dgvGiaPha.CurrentCell.RowIndex;
            string sID = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
            cmd.CommandText = "delete from UserGP where ID = " + sID + "";
            cmd.ExecuteNonQuery();
            KetNoi();
        }
    }
}
