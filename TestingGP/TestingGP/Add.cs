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

        BTree tree = new BTree();
        Node node = null;
        Node root = null;

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
                    for (int i = 0; i < dtGiaPha.Rows.Count; i++)
                    {
                        GIAPHA gp = new GIAPHA();
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
                        node = tree.InsertTree(node, gp);
                    }
                    root = node;
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
            ShowTreeView();
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
                AddToSQL(T.pLeft);
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
                AddToSQL(T.pRight);
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            GIAPHA gp = new GIAPHA();
            CreateGP(gp);
            tree.InsertTree(root, gp);
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
            AddToSQL(root);
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DataTable Connect(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        void ShowTreeView()
        {
            AddNode(conn, treeViewShowAdd.Nodes);
        }
        void AddNode(SqlConnection con, TreeNodeCollection nc, String filter = "ThếHệ=1")
        {
            DataTable node = Connect("SELECT HọTên FROM UserGP WHERE " + filter, con);
            for (int i = 0; i < node.Rows.Count; i++)
            {
                TreeNode t = nc.Add(node.Rows[i][0].ToString());
                t.Tag = (t.Level + 1).ToString();
                AddNode(con, t.Nodes, "HọtênCha=N'" + node.Rows[i][0].ToString() + "'");
            }
        }
        private void btXemCay_Click(object sender, EventArgs e)
        {
            // KetNoi();
            dgvGiaPha.Visible = false;
            treeViewShowAdd.Visible = true;
        }
        private void btXemDS_Click(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowAdd.Visible = false;
        }
        private void treeViewShowAdd_AfterSelect(object sender, TreeViewEventArgs e)
        {
           /* MessageBox.Show(e.Node.ToString());
            if (e.Node != null)
            {
                Node p = new Node();

                p = ReSearchNode(tree.root, e.Node.ToString());
                MessageBox.Show(p.inFO.hoTen);

                #region
                /*DataTable node = Connect("select * from UserGP where Họtên = N'" + e.Node.Text + "'", conn);
                txtMaTV.Text = node.Rows[0][1].ToString();
                txtTheHe.Text = node.Rows[0][2].ToString();
                if (node.Rows[0][3].ToString() == "Có")
                    chbThuocGP.Checked = true;
                else chbThuocGP.Checked = false;
                txtHoTen.Text = node.Rows[0][4].ToString();
                if (node.Rows[0][5].ToString() == "Nam")
                    chbGioiTinh.Checked = true;
                else chbGioiTinh.Checked = false;
                dateNgaySinh.Text = node.Rows[0][6].ToString();
                if (node.Rows[0][7].ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateNgayMat.Visible = true;
                    dateNgayMat.Text = node.Rows[0][7].ToString();
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateNgayMat.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtQueQuan.Text = node.Rows[0][8].ToString();
                txtNgheNghiep.Text = node.Rows[0][9].ToString();
                txtHotenCha.Text = node.Rows[0][10].ToString();
                txtHotenMe.Text = node.Rows[0][11].ToString();
                txtTenVoChong.Text = node.Rows[0][12].ToString();
                txtHotenCon.Text = node.Rows[0][13].ToString();
                txtGhiChu.Text = node.Rows[0][14].ToString(); 
                #endregion
            }
            MessageBox.Show(tree.root.inFO.hoTen.ToString());
            */
        }
        private void checkNamMat_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkNamMat.Checked == true)
            {
                checkNamMat.Visible = false;
                lbMat.Visible = true;
                dateNgayMat.Visible = true;
            }
        }
    }
}