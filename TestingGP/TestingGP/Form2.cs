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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GIAPHA;Integrated Security=True");
        SqlDataAdapter daGiaPha = null;
        DataTable dtGiaPha = null;

        //Xem thông tin những người cùng thế hệ
        private void ketnoicsdl1()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where ThếHệ=" + textBox1.Text, conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoicsdl1();
        }
        //Xem thông tin một người
        private void Ketnoicsdl2()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP where Họvàtên like N'%" + textBox2.Text + "%' ", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
   
        
       
        


        
        private void loaddata()
        {
            
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select * from CayGP ", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btShowAll_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Ketnoicsdl2();
        }
        //Xem thế hệ ông bà con cháu
            //Ông bà
        private void Ketnoicsdl3()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select CayGP.* from CayGP,(select *from CayGP where CayGP.Họvàtên=N'" + textBox3.Text + "') as A where CayGP.ThếHệ>A.ThếHệ ", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ketnoicsdl3();
        }
        //Con cháu
        private void Ketnoicsdl4()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                daGiaPha = new SqlDataAdapter("select CayGP.* from CayGP,(select *from CayGP where CayGP.Họvàtên=N'" + textBox3.Text + "') as A where CayGP.ThếHệ<A.ThếHệ ", conn);
                dtGiaPha = new DataTable();
                daGiaPha.Fill(dtGiaPha);
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ketnoicsdl4();
        }
        //Danh sách những người thuộc gia phả
            //Thuộc
        private void KetnoicsdlCo()
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
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            KetnoicsdlCo();
        }
        //Không thuộc
        private void KetnoicsdlKhong()
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
                dataGridView1.DataSource = dtGiaPha;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AllowUserToAddRows = false; //không cho thêm trực tiếp
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không chỉnh sửa trực tiếp
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KetnoicsdlKhong();
        }
    }
}
