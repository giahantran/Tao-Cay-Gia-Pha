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
//using System.Web.UI.WebControls;

namespace TestingGP
{
    public partial class FormDisplay : Form
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

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string gt, tgp;
            if (checkBGioiTinh.Checked == false) gt = "Nữ";
            else gt = "Nam";
            if (checkBThuocGP.Checked == false) tgp = "Không";
            else tgp = "Có";
            cmd.CommandText = "insert into CayGP values ('" +
                this.combMaTV.Text + "', '" +
                this.combTheHe.Text + "', '" +
                tgp + "', '" +
                this.txtbHoTen.Text + "', '" +
                gt + "','" +
                this.dateTimePicker1.Text + "','" +
                this.dateTimePicker2.Text + "','" +
                this.txtBQueQuan.Text + "','" +
                this.txtBNgheNghiep.Text + "','" +
                this.txtBHotenCha.Text + "','" +
                this.txtBHoTenMe.Text + "','" +
                this.txtBHoTenVC.Text + "','" +
                this.txtBHoTenCon.Text + "','" +
                this.txtBGhiChu.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            KetNoi();

            //conn.Close();
            //conn.Dispose();
            //conn = null;
            //Dispose();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowDisplay.Visible = false;
            for (int i = 1; i <= 1000; i++)
            {
                combMaTV.Items.Add(i).ToString();
                combTheHe.Items.Add(i).ToString();
            }
            KetNoi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            int r = dgvGiaPha.CurrentCell.RowIndex;
            string sID = dgvGiaPha.Rows[r].Cells[0].Value.ToString();
            string sTH = dgvGiaPha.Rows[r].Cells[1].Value.ToString();
            cmd.CommandText = "delete from CayGP where ID = " + sID + " and [Thế Hệ] = " + sTH + "";
            cmd.ExecuteNonQuery();
            KetNoi();
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            this.combMaTV.Items.Clear();
            this.combTheHe.Items.Clear();
            this.checkBThuocGP.Checked = false;
            this.txtbHoTen.Text = "";
            this.checkBGioiTinh.Checked = false;
            this.dateTimePicker1.Text = "";
            this.dateTimePicker2.Text = "";
            this.txtBQueQuan.Text = "";
            this.txtBNgheNghiep.Text = "";
            this.txtBHotenCha.Text = "";
            this.txtBHoTenMe.Text = "";
            this.txtBHoTenVC.Text = "";
            this.txtBHoTenCon.Text = "";
            this.txtBGhiChu.Text = "";
            Display_Load(sender, e);
        }

        private void btXemCay_Click(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = false;
            treeViewShowDisplay.Visible = true;
        }
        private DataTable LoadParentTable()
        {
            DataTable dataTable = new DataTable();
            DataTable dataTableNew = new DataTable();
            conn.Open();
            string commandText = "SELECT * FROM CayGP";
            SqlCommand command = new SqlCommand(commandText, conn);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(dataTable);
            command.ExecuteNonQuery();
            conn.Close();
            dataTableNew = dataTable.Copy();

            return dataTableNew;
        }
        private DataTable LoadChildTable()
        {
            DataTable dataTable = new DataTable();
            DataTable dataTableNew = new DataTable();
            conn.Open();
            string commandText = "SELECT * FROM NodeChild";
            SqlCommand command = new SqlCommand(commandText, conn);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(dataTable);
            command.ExecuteNonQuery();
            conn.Close();
            dataTableNew = dataTable.Copy();

            return dataTableNew;
        }
        private void btXemDS_Click(object sender, EventArgs e)
        {
            dgvGiaPha.Visible = true;
            treeViewShowDisplay.Visible = false;
        }
        private void ShowTreeView()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable tableParent = new DataTable();
                DataTable tableChild = new DataTable();
                tableParent = LoadParentTable();
                tableParent.TableName = "TableParent";
                tableChild = LoadChildTable();
                tableChild.TableName = "TableChild";

                ds.Tables.Add(tableParent);
                ds.Tables.Add(tableChild);
                ds.Relations.Add("MyRelation", tableParent.Columns["ID"], tableChild.Columns["IDParent"]);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    treeViewShowDisplay.Nodes.Clear();

                    /*foreach (DataRow masterRow in ds.Tables[0].Rows)
                    {
                        TreeNode parentNode = new TreeNode(masterRow["TenQuocGia"].ToString());
                        treeViewShowDisplay.Nodes.Add(parentNode);
                        treeViewShowDisplay.CollapseAll();
                        foreach (DataRow childRow in masterRow.GetChildRows("MyRelation"))
                        {
                            TreeNode childNode = new TreeNode(childRow["TenNhanVien"].ToString(), childRow["MaNhanVien"].ToString());
                            parentNode.ChildNodes.Add(childNode);
                            childNode.Value = childRow["MaNhanVien"].ToString();
                        }
                    }*/
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Không kết nối được CSDL" + ex.Message);
            }
        }
        
    }
    /* private void ShowTreeView()
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

     }*/
}
//}