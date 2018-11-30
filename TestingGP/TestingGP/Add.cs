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
                #region Add to binary tree
                if (dtGiaPha != null)
                {
                    GIAPHA gp = new GIAPHA();
                    for (int i = 0; i < dtGiaPha.Rows.Count; i++)
                    {
                        gp.IDGP = Convert.ToInt32(dtGiaPha.Rows[i][0]);
                        gp.iD = Convert.ToInt32(dtGiaPha.Rows[i][1]);
                        gp.theHe = Convert.ToInt32(dtGiaPha.Rows[i][2]);
                        gp.thuocGP = dtGiaPha.Rows[i][3].ToString();
                        gp.hoTen = dtGiaPha.Rows[i][4].ToString();
                        gp.gioiTinh = dtGiaPha.Rows[i][5].ToString();
                        gp.namSinh = dtGiaPha.Rows[i][6].ToString();
                        gp.namMat = dtGiaPha.Rows[i][7].ToString();
                        gp.noiSinh = dtGiaPha.Rows[i][8].ToString();
                        gp.ngheNghiep = dtGiaPha.Rows[i][9].ToString();
                        gp.cha = dtGiaPha.Rows[i][10].ToString();
                        gp.me = dtGiaPha.Rows[i][11].ToString();
                        gp.tenVoChong = dtGiaPha.Rows[i][12].ToString();
                        gp.tenCon = dtGiaPha.Rows[i][13].ToString();
                        gp.ghiChu = dtGiaPha.Rows[i][14].ToString();
                        tree.InsertNode(gp);
                    }
                }
                #endregion
                dgvGiaPha.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvGiaPha.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dgvGiaPha.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void Disconnect()
        {
            conn.Close(); //Đóng kết nối
            conn.Dispose(); //Giải phóng tài nguyên
            conn = null; //Hủy đối tượng
        }
        public Add()
        {
            InitializeComponent();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            this.dgvGiaPha.Location = new Point(410, 82);
            this.treeViewShowAdd.Location = new Point(410, 82);
            dgvGiaPha.Visible = true;
            treeViewShowAdd.Visible = false;
            this.txtIDGiaPha.Text = "1";
            KetNoi();
        }
        public void CreateGP(GIAPHA gp)
        {
            gp.IDGP = Convert.ToInt32(txtIDGiaPha.Text);
            gp.iD = Convert.ToInt32(txtMaTV.Text);
            gp.theHe = Convert.ToInt32(txtTheHe.Text);
            gp.hoTen = txtHoTen.Text;
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
        public void AddToDataGridView(GIAPHA gp)
        {
            DataRow row = dtGiaPha.NewRow();
            row["IDGP"] = Convert.ToInt32(txtIDGiaPha.Text);
            row["ID"] = gp.iD;
            row["Thếhệ"] = gp.theHe;
            row["ThuộcGiaPhả"] = gp.thuocGP;
            row["Họtên"] = gp.hoTen;
            row["Giớitính"] = gp.gioiTinh;
            row["NgàySinh"] = gp.namSinh;
            row["NgàyMất"] = gp.namMat;
            row["Nơisinh"] = gp.noiSinh;
            row["Nghềnghiệp"] = gp.ngheNghiep;
            row["HọtênCha"] = gp.cha;
            row["HọtênMẹ"] = gp.me;
            row["TênVợ_Chồng"] = gp.tenVoChong;
            row["HọtênCon"] = gp.tenCon;
            row["Ghichú"] = gp.ghiChu;
            dtGiaPha.Rows.Add(row);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void AddToSQL(Node T)
        {
            if (T != null)
            {
                SqlCommand cmdAdd = new SqlCommand();
                cmdAdd.Connection = conn;
                cmdAdd.CommandType = CommandType.Text;
                cmdAdd.CommandText = @"Insert into UserGP (IDGP, ID, Thếhệ, ThuộcGiaPhả, Họtên, Giớitính, Ngàysinh, Ngàymất, Nơisinh, Nghềnghiệp, HọtênCha, HọtênMẹ, TênVợ_Chồng, HọtênCon, Ghichú) Values (@IDGP, @ID, @Thếhệ, @ThuộcGiaPhả, @Họtên, @Giớitính, @Ngàysinh, @Ngàymất, @Nơisinh, @Nghềnghiệp, @HọtênCha, @HọtênMẹ, @TênVợ_Chồng, @HọtênCon, @Ghichú)";
                cmdAdd.Parameters.Add("@IDGP", SqlDbType.Int, 5, "IDGP");
                cmdAdd.Parameters.Add("@ID", SqlDbType.Int, 5, "ID");
                cmdAdd.Parameters.Add("@Thếhệ", SqlDbType.Int, 5, "Thếhệ");
                cmdAdd.Parameters.Add("@ThuộcGiaPhả", SqlDbType.NVarChar, 10, "ThuộcGiaPhả");
                cmdAdd.Parameters.Add("@Họtên", SqlDbType.NVarChar, 50, "Họtên");
                cmdAdd.Parameters.Add("@Giớitính", SqlDbType.NVarChar, 5, "Giớitính");
                cmdAdd.Parameters.Add("@Ngàysinh", SqlDbType.NVarChar, 10, "Ngàysinh");
                cmdAdd.Parameters.Add("@Ngàymất", SqlDbType.Date, 12, "Ngàymất");
                cmdAdd.Parameters.Add("@Nơisinh", SqlDbType.NVarChar, 50, "Nơisinh");
                cmdAdd.Parameters.Add("@Nghềnghiệp", SqlDbType.NVarChar, 50, "Nghềnghiệp");
                cmdAdd.Parameters.Add("@HọtênCha", SqlDbType.NVarChar, 50, "HọtênCha");
                cmdAdd.Parameters.Add("@HọtênMẹ", SqlDbType.NVarChar, 50, "HọtênMẹ");
                cmdAdd.Parameters.Add("@TênVợ_Chồng", SqlDbType.NVarChar, 50, "TênVợ_Chồng");
                cmdAdd.Parameters.Add("@HọtênCon", SqlDbType.NVarChar, 200, "HọtênCon");
                cmdAdd.Parameters.Add("@Ghichú", SqlDbType.NVarChar, 200, "Ghichú");
                daGiaPha.InsertCommand = cmdAdd;
                daGiaPha.Update(dtGiaPha);
                AddToSQL(T.pleft);
                AddToSQL(T.pright);
            }
        }
        public class GIAPHA
        {
            public int iD, theHe, IDGP;
            public string hoTen, cha, me, tenVoChong, tenCon;
            public string gioiTinh, thuocGP;
            public string namSinh, namMat;
            public string noiSinh, ngheNghiep, ghiChu;
        }
        public class Node
        {
            private GIAPHA info;
            private Node pLeft;
            private Node pRight;
            private string key;
            public Node(GIAPHA gpha)
            {
                info = gpha;
                key = info.hoTen;
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
            public void AddNode(GIAPHA gp)
            {
                if (string.Compare(key, gp.hoTen) == 0)
                {
                    MessageBox.Show("Thông tin đã có trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.Compare(key, gp.hoTen) == -1)
                {
                    if (pLeft == null) pLeft = new Node(gp);
                    else pLeft.AddNode(gp);
                }
                else
                {
                    if (pRight == null) pRight = new Node(gp);
                    else pRight.AddNode(gp);
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
            public void InsertNode(GIAPHA gp)
            {
                if (root == null)
                    root = new Node(gp);
                else root.AddNode(gp);
            }
        }
        public BTree tree = new BTree();
        private void btThem_Click(object sender, EventArgs e)
        {
            GIAPHA gp = new GIAPHA();
            CreateGP(gp);
            tree.InsertNode(gp);
            AddToDataGridView(gp);
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
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Dispose();
            System.GC.Collect();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            AddToSQL(tree.root);
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}