using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGP
{
    public class GIAPHA
    {
        public int iD, theHe, IDGP;
        public string hoTen, cha, me, tenVoChong, tenCon;
        public string gioiTinh, thuocGP;
        public string namSinh, namMat;
        public string noiSinh, ngheNghiep, ghiChu;
    }
    public class Node
    {
        public GIAPHA info;
        public Node pLeft;
        public Node pRight;
    }
    public class BTree
    {
        public Node InsertTree(Node root, GIAPHA gp)
        {
            if (root == null)
            {
                root = new Node();
                root.info = gp;
            }
            else if (string.Compare(root.info.hoTen, gp.hoTen) == 1)
            {
                root.pLeft = InsertTree(root.pLeft, gp);
            }
            else if (string.Compare(root.info.hoTen, gp.hoTen) == -1)
            {
                root.pRight = InsertTree(root.pRight, gp);
            }
            return root;
        }
        public string SearchNode(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.hoTen, name) == 0)
                    return name;
                else if (string.Compare(root.info.hoTen, name) == 1)
                    return SearchNode(root.pLeft, name);
                return SearchNode(root.pRight, name);
            }
            return null;
        }

    }
}
