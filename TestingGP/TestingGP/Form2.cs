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
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GIAPHA;Integrated Security=True");
        private void Ketnoicsdl()
        {
            cnn.Open();
            string sql1 = "select * from thongtingiapha where [Thế hệ]=1";
            string sql2 = "select * from thongtingiapha where [Thế hệ]=2";
            string sql3 = "select * from thongtingiapha where [Thế hệ]=3";
            string sql4 = "select * from thongtingiapha where [Thế hệ]=4";
            string sql5 = "select * from thongtingiapha where [Thế hệ]=5";
            string sql6 = "select * from thongtingiapha where [Thế hệ]=6";
            string sql = "";
            if (comboBox1.Text == "1")
                sql = sql1;
            if (comboBox1.Text == "2")
                sql = sql2;
            if (comboBox1.Text == "3")
                sql = sql3;
            if (comboBox1.Text == "4")
                sql = sql4;
            if (comboBox1.Text == "5")
                sql = sql5;
            if (comboBox1.Text == "6")
                sql = sql6;


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
            Ketnoicsdl();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
