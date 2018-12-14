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
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C99VFUB\GIAHAN;Initial Catalog=GIAPHA;Integrated Security=True"); //Hân
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
                treeViewShowAdd.Nodes.Clear();
                #region Add to binary tree
                daGiaPha = new SqlDataAdapter("select * from UserGP", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dgvGiaPha.DataSource = dtGiaPha;
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
                ShowTreeView();
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
            lbMat.Visible = false;
            dateNgayMat.Visible = false;
            this.txtIDGiaPha.Text = "1";
            this.txtTenGp.Text = "admin";
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
            if (checkNamMat.Checked == true)
                gp.namMat = DateTime.Parse(dateNgayMat.Text).ToString();
            else gp.namMat = "";
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
        }
        public void AddToSQL(Node T)
        {
            if (T != null)
            {
                AddToSQL(T.pLeft);
                #region Thêm dữ liệu vào CSDL
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
                cmdAdd.Parameters.Add("@Ngàysinh", SqlDbType.Date, 10, "Ngàysinh");
                cmdAdd.Parameters.Add("@Ngàymất", SqlDbType.NVarChar, 10, "Ngàymất");
                cmdAdd.Parameters.Add("@Nơisinh", SqlDbType.NVarChar, 50, "Nơisinh");
                cmdAdd.Parameters.Add("@Nghềnghiệp", SqlDbType.NVarChar, 50, "Nghềnghiệp");
                cmdAdd.Parameters.Add("@HọtênCha", SqlDbType.NVarChar, 50, "HọtênCha");
                cmdAdd.Parameters.Add("@HọtênMẹ", SqlDbType.NVarChar, 50, "HọtênMẹ");
                cmdAdd.Parameters.Add("@TênVợ_Chồng", SqlDbType.NVarChar, 50, "TênVợ_Chồng");
                cmdAdd.Parameters.Add("@HọtênCon", SqlDbType.NVarChar, 200, "HọtênCon");
                cmdAdd.Parameters.Add("@Ghichú", SqlDbType.NVarChar, 200, "Ghichú");
                daGiaPha.InsertCommand = cmdAdd;
                daGiaPha.Update(dtGiaPha);
                #endregion
                AddToSQL(T.pRight);
            }
        }
        bool checkThem = false;
        private void btThem_Click(object sender, EventArgs e)
        {
            GIAPHA gp = new GIAPHA();
            CreateGP(gp);
            GIAPHA x = tree.SearchNode(root, gp.hoTen);
            if (x != null)
            {
                MessageBox.Show("Tên này đã có trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                root = tree.InsertTree(root, gp);
                AddToDataGridView(gp);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                checkThem = true;
            }
            x = null;
        }
        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            this.txtMaTV.Text = "";
            this.txtTheHe.Text = "";
            this.chbThuocGP.Checked = false;
            this.txtHoTen.Text = "";
            this.chbGioiTinh.Checked = false;
            this.dateNgaySinh.Text = "";
            this.lbMat.Visible = false;
            this.dateNgayMat.Visible = false;
            this.checkNamMat.Visible = true;
            this.checkNamMat.Checked = false;
            this.txtQueQuan.Text = "";
            this.txtNgheNghiep.Text = "";
            this.txtHotenCha.Text = "";
            this.txtHotenMe.Text = "";
            this.txtTenVoChong.Text = "";
            this.txtHotenCon.Text = "";
            this.txtGhiChu.Text = "";
            KetNoi();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGiaPha.CurrentRow;
                GIAPHA search = tree.SearchNode(root, row.Cells["Họtên"].Value.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                int r = dgvGiaPha.CurrentCell.RowIndex;
                string sID = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
                cmd.CommandText = "Delete from UserGP where ID = " + sID + "";
                cmd.ExecuteNonQuery();
                if (search != null)
                {
                    search = new GIAPHA();
                    CreateGP(search);
                    GIAPHA x = tree.SearchNode(root, search.hoTen);
                    if (x != null)
                    {
                        MessageBox.Show("Tên này đã có trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        root = tree.InsertTree(root, search);
                        AddToDataGridView(search);
                        AddToSQL(root);
                        KetNoi();
                        EventCellClick();
                    }
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            int r = dgvGiaPha.CurrentCell.RowIndex;
            string sID = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
            tree.Remove(ref root, txtHoTen.Text);
            cmd.CommandText = "Delete from UserGP where ID = " + sID + "";
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
            if (checkThem == true)
            {
                AddToSQL(root);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                GIAPHA gp = new GIAPHA();
                CreateGP(gp);
                GIAPHA x = tree.SearchNode(root, gp.hoTen);
                if (x != null)
                {
                    MessageBox.Show("Tên này đã có trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    root = tree.InsertTree(root, gp);
                    AddToDataGridView(gp);
                    AddToSQL(root);
                }
            }
            KetNoi();
            checkThem = false;
        }
        private DataTable Connect(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        private void ShowTreeView()
        {
            AddNode(conn, treeViewShowAdd.Nodes);
        }
        private void AddNode(SqlConnection con, TreeNodeCollection nc, String filter = "ThếHệ=1")
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
            KetNoi();
            dgvGiaPha.Visible = false;
            treeViewShowAdd.Visible = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
        }
        private void btXemDS_Click(object sender, EventArgs e)
        {
            KetNoi();
            dgvGiaPha.Visible = true;
            treeViewShowAdd.Visible = false;
            btXoa.Enabled = true;
            btSua.Enabled = true;
        }
        private void treeViewShowAdd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                GIAPHA a = tree.SearchNode(root, e.Node.Text);
                txtMaTV.Text = a.iD.ToString();
                txtTheHe.Text = a.theHe.ToString();
                if (a.thuocGP.ToString() == "Có")
                    chbThuocGP.Checked = true;
                else chbThuocGP.Checked = false;
                txtHoTen.Text = a.hoTen;
                if (a.gioiTinh.ToString() == "Nam")
                    chbGioiTinh.Checked = true;
                else chbGioiTinh.Checked = false;
                dateNgaySinh.Text = a.namSinh.ToString();
                if (a.namMat.ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateNgayMat.Visible = true;
                    dateNgayMat.Text = a.namMat;
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateNgayMat.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtQueQuan.Text = a.noiSinh;
                txtNgheNghiep.Text = a.ngheNghiep;
                txtHotenCha.Text = a.cha;
                txtHotenMe.Text = a.me;
                txtTenVoChong.Text = a.tenVoChong;
                txtHotenCon.Text = a.tenCon;
                txtGhiChu.Text = a.ghiChu;
            }
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
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            GIAPHA a = tree.SearchNode(root, txtTimKiem.Text.Trim());
            if (a != null)
            {
                txtMaTV.Text = a.iD.ToString();
                txtTheHe.Text = a.theHe.ToString();
                if (a.theHe.ToString() == "Có")
                    chbThuocGP.Checked = true;
                else chbThuocGP.Checked = false;
                txtHoTen.Text = a.hoTen;
                if (a.gioiTinh.ToString() == "Nam")
                    chbGioiTinh.Checked = true;
                else chbGioiTinh.Checked = false;
                dateNgaySinh.Text = a.namSinh.ToString();
                if (a.namMat.ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateNgayMat.Visible = true;
                    dateNgayMat.Text = a.namMat;
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateNgayMat.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtQueQuan.Text = a.noiSinh;
                txtNgheNghiep.Text = a.ngheNghiep;
                txtHotenCha.Text = a.cha;
                txtHotenMe.Text = a.me.ToString();
                txtTenVoChong.Text = a.tenVoChong;
                txtHotenCon.Text = a.tenCon;
                txtGhiChu.Text = a.ghiChu;
                dtGiaPha.Rows.Clear();
                dgvGiaPha.DataSource = dtGiaPha;
                AddToDataGridView(a);
            }
            else MessageBox.Show("Không có người này trong gia phả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btDelAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tree.RemoveTree(ref root);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                for (int i = 0; i < dgvGiaPha.Rows.Count; i++)
                {
                    string sID = dgvGiaPha.Rows[i].Cells[1].Value.ToString();
                    cmd.CommandText = "Delete from UserGP where ID = " + sID + "";
                    cmd.ExecuteNonQuery();
                }
                KetNoi();
            }
        }
        void EventCellClick()
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvGiaPha.CurrentRow;
            if (row != null)
            {
                txtMaTV.Text = row.Cells["ID"].Value.ToString();
                txtTheHe.Text = row.Cells["ThếHệ"].Value.ToString();
                if (row.Cells["ThuộcGiaPhả"].Value.ToString() == "Có")
                    chbThuocGP.Checked = true;
                else chbThuocGP.Checked = false;
                txtHoTen.Text = row.Cells["Họtên"].Value.ToString();
                if (row.Cells["GiớiTính"].Value.ToString() == "Nam")
                    chbGioiTinh.Checked = true;
                else chbGioiTinh.Checked = false;
                dateNgaySinh.Text = row.Cells["NgàySinh"].Value.ToString();
                if (row.Cells["NgàyMất"].Value.ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateNgayMat.Visible = true;
                    dateNgayMat.Text = row.Cells["NgàyMất"].Value.ToString();
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateNgayMat.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtQueQuan.Text = row.Cells["NơiSinh"].Value.ToString();
                txtNgheNghiep.Text = row.Cells["NghềNghiệp"].Value.ToString();
                txtHotenCha.Text = row.Cells["HọtênCha"].Value.ToString();
                txtHotenMe.Text = row.Cells["HọtênMẹ"].Value.ToString();
                txtTenVoChong.Text = row.Cells["TênVợ_Chồng"].Value.ToString();
                txtHotenCon.Text = row.Cells["HọtênCon"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChú"].Value.ToString();
            }
        }
        private void dgvGiaPha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventCellClick();
        }
        public string LayTenGP()
        {
            return txtTenGp.Text;
        }
        //menu
        //Hàm xuất nhũng người cùng thế hệ
        private void ketnoiTheHe()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from UserGP where ThếHệ = " + txtNhapThehe.Text, conn);
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
        //Hàm xuất những người thuộc gia phả
        private void KetnoiThuoc()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from UserGP where ThuộcGiaPhả=N'Có' ", conn);
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
        //Hàm xuất những người không thuộc gia phả
        private void KetnoiKhongThuoc()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from UserGP where ThuộcGiaPhả=N'không' ", conn);
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
        //Xuất thông tin cha
        public void LeftNodeRightTTcha(Node root)
        {
            if (root != null)
            {
                LeftNodeRightTTcha(root.pLeft);
                string s = tree.SearchNodeTencha(root, txtNhapten.Text);
                GIAPHA a = tree.SearchNode(root, s);
                if (a != null)
                {
                    AddToDataGridView(a);
                    return;
                }
                LeftNodeRightTTcha(root.pRight);
            }
        }
        //Xuất thông tin mẹ
        public void LeftNodeRightTTme(Node root)
        {
            if (root != null)
            {
                LeftNodeRightTTme(root.pLeft);
                string s = tree.SearchNodeTenme(root, txtNhapten.Text);
                GIAPHA a = tree.SearchNode(root, s);
                if (a != null)
                {
                    AddToDataGridView(a);
                    return;
                }
                LeftNodeRightTTme(root.pRight);
            }
        }
        //Xử lý các button
        private void btOkNhapThehe_Click(object sender, EventArgs e)
        {
            ketnoiTheHe();
        }
        private void btThuocGP_Click(object sender, EventArgs e)
        {
            KetnoiThuoc();
        }
        private void btKoThuocGP_Click(object sender, EventArgs e)
        {
            KetnoiKhongThuoc();
        }
        private void btOkMenu_Click(object sender, EventArgs e)
        {
            if (cbbMenu.Text == "Xem những người cùng thế hệ")
            {
                pnTheHe.Visible = true;
                pnThuocGP.Visible = false;
                PnXemBaMe.Visible = false;
            }
            if (cbbMenu.Text == "Xem thông tin ba mẹ")
            {
                pnTheHe.Visible = false;
                pnThuocGP.Visible = false;
                PnXemBaMe.Visible = true;
            }
            if (cbbMenu.Text == "Xem những người thuộc gia phả")
            {
                pnTheHe.Visible = false;
                pnThuocGP.Visible = true;
                PnXemBaMe.Visible = false;
            }
        }
        private void btXemBaMe_Click(object sender, EventArgs e)
        {
            dtGiaPha.Clear();
            LeftNodeRightTTcha(root);
            LeftNodeRightTTme(root);
        }
    }
}