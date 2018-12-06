using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public GIAPHA SearchNode(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.hoTen, name) == 0)
                    return root.info;
                else if (string.Compare(root.info.hoTen, name) == 1)
                    return SearchNode(root.pLeft, name);
                return SearchNode(root.pRight, name);
            }
            return null;
        }
        int n = 0;
        public void LeftNodeRight(Node root, GIAPHA[] NLR)
        {
            if (root != null)
            {
                LeftNodeRight(root.pLeft, NLR);
                NLR[n++] = root.info;
                LeftNodeRight(root.pRight, NLR);
            }
        }
        public void Replace(Node p, Node q)
        {
            if (q.pLeft != null)
                Replace(p, q.pLeft);
            else
            {
                p.info = q.info;
                p = q;
                q = p.pRight;
            }
        }
        public bool Remove(ref Node root, string DelWord)
        {
            if (root == null) return false;
            if (string.Compare(root.info.hoTen, DelWord) == 1)
                return Remove(ref root.pLeft, DelWord);
            if (string.Compare(root.info.hoTen, DelWord) == -1)
                return Remove(ref root.pRight, DelWord);
            Node p = root;
            if (root.pLeft == null) root = root.pRight;
            else
            {
                if (root.pRight == null) root = root.pLeft;
                else Replace(p, root.pRight);
            }
            p = null;
            return true;
        }
        public void RemoveTree(ref Node root)
        {
            if (root != null)
            {
                RemoveTree(ref root.pLeft);
                RemoveTree(ref root.pRight);
                root = null;
            }
        }
    }
}