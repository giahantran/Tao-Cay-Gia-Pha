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
    public partial class Display : Form
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
                daGiaPha = new SqlDataAdapter("select * from CayGP", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dgvGiaPha.DataSource = dtGiaPha;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            KetNoi();
        }

        public Display()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //Add add = new Add();
            //add.layDuLieu(dgvGiaPha);
            //add.ShowDialog();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into CayGP values ('" +
                this.combMaTV.Text + "', '" +
                this.combTheHe.Text + "', null, '" +
                //this.checkBThuocGP.Text + "', '" +
                this.txtbHoTen.Text + "',null,null,null,null,null,null,null,null,null)";
            cmd.ExecuteNonQuery();
            KetNoi();
        }
        private void Display_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtbNgaySinh_Click(object sender, EventArgs e)
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Controls.Add(this.monthCalendar1);

            this.monthCalendar1.Name = "monthCalendar1";
            Point p = new Point(75, 135);
            this.monthCalendar1.Visible = true;
            this.monthCalendar1.Location = p;
            monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(monthCalendar1_DateChanged);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtbNgaySinh.Text = e.End.ToString("MM/dd/yyyy");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            int r = dgvGiaPha.CurrentCell.RowIndex;
            string sID = dgvGiaPha.Rows[r].Cells[0].Value.ToString();
            string sTH = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
            cmd.CommandText = "delete from CayGP where ID = " + sID + " and ThếHệ = " + sTH + "";
            cmd.ExecuteNonQuery();
            KetNoi();
        }
        
    }
}