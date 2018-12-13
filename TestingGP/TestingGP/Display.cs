using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace TestingGP
{
    public partial class FormDisplay : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C99VFUB\GIAHAN;Initial Catalog=GIAPHA;Integrated Security=True"); //Hân
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
                daGiaPha = new SqlDataAdapter("select * from CayGP", conn);
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
        public FormDisplay()
        {
            InitializeComponent();
        }
        public void Display_Load(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowDisplay.Visible = false;
            checkNamMat.Visible = true;
            checkNamMat.Checked = false;
            lbMat.Visible = false;
            dateTimePicker2.Visible = false;
            KetNoi();
            ShowTreeView();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string gt, tgp, nammat;
            if (checkBGioiTinh.Checked == false) gt = "Nữ";
            else gt = "Nam";
            if (checkBThuocGP.Checked == false) tgp = "Không";
            else tgp = "Có";
            if (checkNamMat.Checked == false) nammat = "";
            else nammat = this.dateTimePicker2.Text;
            cmd.CommandText = "insert into CayGP values ('" +
                '1' + "', '" +
                this.txtMaTV.Text + "', '" +
                this.txtTheHe.Text + "', N'" +
                tgp + "', N'" +
                this.txtbHoTen.Text + "', N'" +
                gt + "','" +
                this.dateTimePicker1.Text + "','" +
                nammat + "',N'" +
                this.txtBQueQuan.Text + "',N'" +
                this.txtBNgheNghiep.Text + "',N'" +
                this.txtBHotenCha.Text + "',N'" +
                this.txtBHoTenMe.Text + "',N'" +
                this.txtBHoTenVC.Text + "',N'" +
                this.txtBHoTenCon.Text + "',N'" +
                this.txtBGhiChu.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            KetNoi();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string gt, tgp, nammat;
                if (checkBGioiTinh.Checked == false) gt = "Nữ";
                else gt = "Nam";
                if (checkBThuocGP.Checked == false) tgp = "Không";
                else tgp = "Có";
                if (checkNamMat.Checked == false) nammat = "";
                else nammat = this.dateTimePicker2.Text;
                cmd.CommandText = "update CayGP set IDGP ='" +
                    '1' + "', ID ='" +
                    this.txtMaTV.Text + "', ThếHệ ='" +
                    this.txtTheHe.Text + "', ThuộcGiaPhả =N'" +
                    tgp + "', Họvàtên =N'" +
                    this.txtbHoTen.Text + "', Giớitính =N'" +
                    gt + "', NgàySinh ='" +
                    this.dateTimePicker1.Text + "', NgàyMất ='" +
                    nammat + "', NơiSinh =N'" +
                    this.txtBQueQuan.Text + "', NghềNghiệp =N'" +
                    this.txtBNgheNghiep.Text + "', HọtênCha =N'" +
                    this.txtBHotenCha.Text + "', HọtênMẹ =N'" +
                    this.txtBHoTenMe.Text + "', TênVợ_Chồng =N'" +
                    this.txtBHoTenVC.Text + "', HọtênCon =N'" +
                    this.txtBHoTenCon.Text + "',GhiChú =N'" +
                    this.txtBGhiChu.Text +
                    "' where ID ='" + this.txtMaTV.Text +
                    "' and ThếHệ ='" + this.txtTheHe.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                KetNoi();
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int r = dgvGiaPha.CurrentCell.RowIndex;
                string sID = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
                string sTH = dgvGiaPha.Rows[r].Cells[2].Value.ToString();
                cmd.CommandText = "delete from CayGP where ID = " + sID + " and [ThếHệ] = " + sTH + "";

                cmd.ExecuteNonQuery();
                KetNoi();
            }
        }
        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            this.txtMaTV.Text = "";
            this.txtTheHe.Text = "";
            this.checkBThuocGP.Checked = false;
            this.txtbHoTen.Text = "";
            this.checkBGioiTinh.Checked = false;
            this.dateTimePicker1.Text = "";
            this.lbMat.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.checkNamMat.Visible = true;
            this.checkNamMat.Checked = false;
            this.txtBQueQuan.Text = "";
            this.txtBNgheNghiep.Text = "";
            this.txtBHotenCha.Text = "";
            this.txtBHoTenMe.Text = "";
            this.txtBHoTenVC.Text = "";
            this.txtBHoTenCon.Text = "";
            this.txtBGhiChu.Text = "";
            KetNoi();
        }
        private void btXemCay_Click(object sender, EventArgs e)
        {
            KetNoi();
            dgvGiaPha.Visible = false;
            treeViewShowDisplay.Visible = true;
        }
        private void btXemDS_Click(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowDisplay.Visible = false;
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
            AddNode(conn, treeViewShowDisplay.Nodes);
        }
        void AddNode(SqlConnection con, TreeNodeCollection nc, String filter = "ThếHệ=1")
        {
            DataTable node = Connect("SELECT HọvàTên FROM CayGP WHERE " + filter, con);

            for (int i = 0; i < node.Rows.Count; i++)
            {
                TreeNode t = nc.Add(node.Rows[i][0].ToString());
                t.Tag = (t.Level + 1).ToString();
                AddNode(con, t.Nodes, "HọtênCha=N'" + node.Rows[i][0].ToString() + "'");
            }
        }
        //Tìm kiếm người trong gia phả
        private void Ketnoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where Họvàtên like N'%" + textBox1.Text + "%' ", conn);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ketnoi();
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            Ketnoi();
        }
        //Khi nhấn OK ở comboBox1
        //Chọn công việc muốn làm
        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Xem những người cùng thế hệ")
            {
                panel2.Show();
                panel1.Hide();
                panel3.Hide();
            }
            if (comboBox1.Text == "Xem thế hệ con cháu ông bà")
            {
                panel1.Show();
                panel2.Hide();
                panel3.Hide();
            }
            if (comboBox1.Text == "Xem những người thuộc gia phả")
            {
                panel3.Show();
                panel1.Hide();
                panel2.Hide();
            }
        }
        //Xem ông bà con cháu
        //Xem ông bà
        private void Ketnoiob()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select CayGP.* from CayGP,(select *from CayGP where CayGP.Họvàtên=N'" + textBox2.Text + "') as A where CayGP.ThếHệ<A.ThếHệ ", conn);
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
        private void button1_Click(object sender, EventArgs e)
        {
            Ketnoiob();
        }
        //Xem con cháu
        private void Ketnoicc()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select CayGP.* from CayGP,(select *from CayGP where CayGP.Họvàtên=N'" + textBox2.Text + "') as A where CayGP.ThếHệ>A.ThếHệ ", conn);
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
        private void button2_Click(object sender, EventArgs e)
        {
            Ketnoicc();
        }
        //Xuất những người cùng thế hệ
        private void ketnoitt()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where ThếHệ=" + textBox3.Text, conn);
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
        private void button3_Click(object sender, EventArgs e)
        {
            ketnoitt();
        }
        //Xuất những người thuộc hay không thuộc gia phả
        private void KetnoiCo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where ThuộcGiaPhả=N'Có' ", conn);
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
        private void button4_Click(object sender, EventArgs e)
        {
            KetnoiCo();
        }
        private void KetnoiKhong()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where ThuộcGiaPhả=N'Không' ", conn);
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
        private void button5_Click(object sender, EventArgs e)
        {
            KetnoiKhong();
        }
        private void FormDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Dispose();
            System.GC.Collect();
        }
        private void checkNamMat_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkNamMat.Checked == true)
            {
                checkNamMat.Visible = false;
                lbMat.Visible = true;
                dateTimePicker2.Visible = true;
            }
        }
        private void treeViewShowDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                DataTable node = Connect("select * from CayGP where Họvàtên = N'" + e.Node.Text + "'", conn);
                txtMaTV.Text = node.Rows[0][1].ToString();
                txtTheHe.Text = node.Rows[0][2].ToString();
                if (node.Rows[0][3].ToString() == "Có")
                    checkBThuocGP.Checked = true;
                else checkBThuocGP.Checked = false;
                txtbHoTen.Text = node.Rows[0][4].ToString();
                if (node.Rows[0][5].ToString() == "Nam")
                    checkBGioiTinh.Checked = true;
                else checkBGioiTinh.Checked = false;
                dateTimePicker1.Text = node.Rows[0][6].ToString();
                if (node.Rows[0][7].ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Text = node.Rows[0][7].ToString();
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateTimePicker2.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtBQueQuan.Text = node.Rows[0][8].ToString();
                txtBNgheNghiep.Text = node.Rows[0][9].ToString();
                txtBHotenCha.Text = node.Rows[0][10].ToString();
                txtBHoTenMe.Text = node.Rows[0][11].ToString();
                txtBHoTenVC.Text = node.Rows[0][12].ToString();
                txtBHoTenCon.Text = node.Rows[0][13].ToString();
                txtBGhiChu.Text = node.Rows[0][14].ToString();
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
                    checkBThuocGP.Checked = true;
                else checkBThuocGP.Checked = false;
                txtbHoTen.Text = row.Cells["Họvàtên"].Value.ToString();
                if (row.Cells["GiớiTính"].Value.ToString() == "Nam")
                    checkBGioiTinh.Checked = true;
                else checkBGioiTinh.Checked = false;
                dateTimePicker1.Text = row.Cells["NgàySinh"].Value.ToString();
                if (row.Cells["NgàyMất"].Value.ToString() != "")
                {
                    checkNamMat.Visible = false;
                    lbMat.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Text = row.Cells["NgàyMất"].Value.ToString();
                }
                else
                {
                    checkNamMat.Visible = true;
                    lbMat.Visible = false;
                    dateTimePicker2.Visible = false;
                    checkNamMat.Checked = false;
                }
                txtBQueQuan.Text = row.Cells["NơiSinh"].Value.ToString();
                txtBNgheNghiep.Text = row.Cells["NghềNghiệp"].Value.ToString();
                txtBHotenCha.Text = row.Cells["HọtênCha"].Value.ToString();
                txtBHoTenMe.Text = row.Cells["HọtênMẹ"].Value.ToString();
                txtBHoTenVC.Text = row.Cells["TênVợ_Chồng"].Value.ToString();
                txtBHoTenCon.Text = row.Cells["HọtênCon"].Value.ToString();
                txtBGhiChu.Text = row.Cells["GhiChú"].Value.ToString();
            }
        }
        private void dgvGiaPha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventCellClick();
        }
    }
}