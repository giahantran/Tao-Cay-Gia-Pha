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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();

        }
        public List<List> ClassGiaPha { get; set; }
        public class GIAPHA
        {
            public int keyID, theHe, parent;
            public string hoTen, cha, me, tenVoChong, tenCon;
            public bool gioiTinh = true, thuocGP = true; //true = nam, true = có trong gia phả
            public string namSinh, namMat;
            public string noiSinh, ngheNghiep, ghiChu;
        }
        public class List : FormAdd
        {
            public class Node
            {
                public GIAPHA info;
                public Node pNext;
            }
            Node pHead;
            Node pTail;
            public List()
            {
                pHead = pTail = null;
            }
            Node CreateNode(GIAPHA gp)
            {
                Node p = new Node();
                if (p != null)
                {
                    p.info = gp;
                    p.pNext = null;
                }
                else
                {
                    MessageBox.Show("Không đủ bộ nhớ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return p;
            }
            public void AddTail(List l, Node p)
            {
                if (l.pHead == null)
                {
                    l.pHead = l.pTail = p;
                }
                else
                {
                    l.pTail.pNext = p;
                    p.pNext = null;
                    l.pTail = p;
                }
            }
            public void AddNodeTail(List l, GIAPHA gp)
            {
                Node p = CreateNode(gp);
                if (p != null) AddTail(l, p);
                else MessageBox.Show("Không đủ bộ nhớ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            public void CreateGiaPha(List l, GIAPHA gp)
            {
                treeViewShow.Visible = false;
                dgvGiaPha.Visible = true;
                gp.keyID = Convert.ToInt32(combMaTV.Text);
                gp.theHe = Convert.ToInt32(combTheHe.Text);
                gp.parent = Convert.ToInt32(txtParent.Text);
                gp.hoTen = txtbHoTen.Text.ToString();
                gp.cha = txtBHotenCha.Text.ToString();
                gp.me = txtBHoTenMe.Text.ToString();
                gp.tenVoChong = txtBHoTenVC.Text.ToString();
                gp.tenCon = txtBHoTenCon.Text.ToString();
                if (checkBGioiTinh.Checked == true) gp.gioiTinh = true;
                else gp.gioiTinh = false;
                if (checkBThuocGP.Checked == true) gp.thuocGP = true;
                else gp.thuocGP = false;
                gp.namSinh = dateNgaySinh.Text.ToString();
                gp.namMat = dateNgayMat.Text.ToString();
                gp.noiSinh = txtBQueQuan.Text.ToString();
                gp.ngheNghiep = txtBNgheNghiep.Text.ToString();
                gp.ghiChu = txtBGhiChu.Text.ToString();
                AddNodeTail(l, gp);
            }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataGridView dt;

        public static string connectionString { get; private set; }

        public void layDuLieu(DataGridView data)
        {
            dt = data;
        }



        private void ShowTreeView()
        {
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                treeViewShow.Nodes.Add(dt.Rows[i].Cells[3].Value.ToString());
                if (i % 2 == 0)
                {

                    //addChildNode(1, dt.Rows[i].Cells[3].Value.ToString());
                }
            }
            treeViewShow.Nodes.Add(dt.Rows[1].Cells[4].Value.ToString());
            addChildNode(1, dt.Rows[2].Cells[4].Value.ToString());
            addChildNode(1, dt.Rows[3].Cells[4].Value.ToString());


            //  addChildNodeMMore();
            //treeViewShow.Nodes.Add(dt.Rows[0].Cells[3].Value.ToString());
            //treeViewShow.Nodes.Add(dt.Rows[1].Cells[3].Value.ToString());

            //TreeNode parentNode = treeViewShow.SelectedNode ?? treeViewShow.Nodes[0];
            //List<TreeNode> Nodes = new List<TreeNode>();
            //AddChild(Nodes, parentNode);

        }
        private void dequy(int i, int j)
        {
            for (int i1 = i; i1 <= j; i1++)
            {

            }
        }
        private void AddChild(List<TreeNode> Nodes, TreeNode Node)
        {
            foreach (TreeNode thisNode in Node.Nodes)
            {
                Nodes.Add(thisNode);
                AddChild(Nodes, thisNode);
            }
        }
        private void addChildNode(int index, string str)
        {
            var childNode = str;
            if (!string.IsNullOrEmpty(childNode))
            {
                TreeNode parentNode = treeViewShow.SelectedNode ?? treeViewShow.Nodes[index];
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(childNode);
                    treeViewShow.ExpandAll();
                }
            }
        }

        private void addChildNodeMMore()
        {
            var childNode = "NA xam";
            if (!string.IsNullOrEmpty(childNode))
            {
                TreeNode parentNode = treeViewShow.SelectedNode ?? treeViewShow.Nodes[0].Nodes[0];
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(childNode);
                    treeViewShow.ExpandAll();
                }
            }
        }

        //private void AddChildNode(TreeNode parentNode, int parent)
        //{
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        TreeNode node = new TreeNode();
        //        node.Text = dr["HOTEN"].ToString();
        //        int childNode = Convert.ToInt32(dr["ID"]);
        //        if(parentNode==null || parent==0)
        //        {
        //            AddChildNode(node, childNode);
        //            treeViewShow.Nodes.Add(node);
        //        }
        //        else
        //        {
        //            AddChildNode(node, childNode);
        //         //   parentNode..Add(node);
        //        }
        //    }
        //}

        //void fill_Tree2()

        //{



        //    DataSet PrSet = PDataset("Select * from ParentTable");

        //    treeViewShow.Nodes.Clear();

        //    foreach (DataRow dr in PrSet.Tables[0].Rows)

        //    {

        //        TreeNode tnParent = new TreeNode();

        //        tnParent.Text = dr["ParentName"].ToString();

        //        tnParent.Value = dr["ParentID"].ToString();

        //        tnParent.PopulateOnDemand = true;

        //        tnParent.ToolTipText = "Click to get Child";

        //        tnParent.SelectAction = TreeNodeSelectAction.SelectExpand;

        //        tnParent.Expand();

        //        tnParent.SelectedImageKey = true;

        //        treeViewShow.Nodes.Add(tnParent);

        //        FillChild(tnParent, tnParent.Value);

        //    }



        //}

        //public void FillChild(TreeNode parent, string ParentId)

        //{

        //    DataSet ds = PDataset("Select * from ChildTable where ParentId =" + ParentId);

        //    parent.ChildNodes.Clear();

        //    foreach (DataRow dr in ds.Tables[0].Rows)

        //    {

        //        TreeNode child = new TreeNode();

        //        child.Text = dr["ChildName"].ToString().Trim();

        //        child.Value = dr["ChildId"].ToString().Trim();

        //        if (child.ChildNodes.Count == 0)

        //        {

        //            child.PopulateOnDemand = true;

        //        }

        //        child.ToolTip = "Click to get Child";

        //        child.SelectAction = TreeNodeSelectAction.SelectExpand;

        //        child.CollapseAll();

        //        parent.ChildNodes.Add(child);

        //    }

        //}



        //protected DataSet PDataset(string Select_Statement)

        //{

        //    SqlConnection SqlCon = new SqlConnection("Data Source=;Integrated Security=True");

        //    SqlDataAdapter ad = new SqlDataAdapter(Select_Statement, SqlCon);

        //    DataSet ds = new DataSet();

        //    ad.Fill(ds);

        //    return ds;



        //}
        private void Add_Load(object sender, EventArgs e)
        {
            ShowTreeView();
            //TreeNode node = null;
            //AddChildNode(node, 0);
        }

    }
}