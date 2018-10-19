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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

        }


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
                    addChildNode(i);
                }
                //if (dt.Rows[i + 1].Cells[0].Value = )
            }
            addChildNodeMMore();
            treeViewShow.Nodes.Add(dt.Rows[0].Cells[3].Value.ToString());
            treeViewShow.Nodes.Add(dt.Rows[1].Cells[3].Value.ToString());

            TreeNode parentNode = treeViewShow.SelectedNode ?? treeViewShow.Nodes[0];
            List<TreeNode> Nodes = new List<TreeNode>();
            AddChild(Nodes, parentNode);

        }
        private void AddChild (List<TreeNode> Nodes, TreeNode Node)
        {
            foreach(TreeNode thisNode in Node.Nodes)
            {
                Nodes.Add(thisNode);
                AddChild(Nodes, thisNode);
            }
        }
        private void addChildNode(int index)
        {
            var childNode = "NA";
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

        private void Add_Load(object sender, EventArgs e)
        {
            ShowTreeView();
           //TreeNode node = null;
           //AddChildNode(node, 0);
        }

    }
}