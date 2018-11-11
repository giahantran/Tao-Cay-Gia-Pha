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
        //Xem thông tin những người cùng thế hệ
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GIAPHA;Integrated Security=True");
        private void ketnoicsdl1()
        {
   
            
            cnn.Open();
            string sql = "select * from CayGP where [Thế Hệ]="+textBox1.Text;  
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoicsdl1();
        }
        //Xem thông tin một người
        private void Ketnoicsdl2()
        {
            cnn.Open();
            string sql = "select * from CayGP where [Họ và tên] like N'%" + textBox2.Text + "%' ";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void loaddata()
        {
            cnn.Open();
            string sql = "select * from CayGP";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
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
            cnn.Open();
            string sql = "select CayGP.* from CayGP,(select *from CayGP where CayGP.[Họ và tên]=N'" + textBox3.Text + "') as A where CayGP.[Thế Hệ]>A.[Thế Hệ]";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ketnoicsdl3();
        }
        //Con cháu
        private void Ketnoicsdl4()
        {
            cnn.Open();
            string sql = "select CayGP.* from CayGP,(select *from CayGP where CayGP.[Họ và tên]=N'" + textBox3.Text + "') as A where CayGP.[Thế Hệ]<A.[Thế Hệ]";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ketnoicsdl4();
        }
    }
}
