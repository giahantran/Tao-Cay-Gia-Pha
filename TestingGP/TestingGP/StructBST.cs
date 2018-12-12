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
        public void Replace( Node p,  Node t)
        {
            if (t.pLeft != null)
                Replace( p,  t.pLeft);
            else
            {
                p.info = t.info;
                t = p.pRight;
                p = t;
            }
        }
        public void Remove(ref Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.hoTen, name) == -1)
                    Remove(ref root.pRight, name);
                else
                {
                    if (string.Compare(root.info.hoTen, name) == 1)
                        Remove(ref root.pLeft, name);
                    else
                    {
                        Node p = root;
                        if (root.pLeft == null) root = root.pRight;
                        else if (root.pRight == null) root = root.pLeft;
                        else Replace( p,  root.pRight);
                        p = null;
                    }
                }
            }
        }
        public void RemoveTree(ref Node root)
        {
            if (root != null)
            {
                RemoveTree(ref root.pLeft);
                RemoveTree(ref root.pRight);
                Remove(ref root, root.info.hoTen);
            }
        }
        //Hàm lấy tên cha của thành viên
        public string SearchNodeTencha(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.hoTen, name) == 0)
                    return root.info.cha;
                else if (string.Compare(root.info.hoTen, name) == 1)
                    return SearchNodeTencha(root.pLeft, name);
                return SearchNodeTencha(root.pRight, name);
            }
            return null;
        }
        //Hàm lấy tên mẹ của thành viên
        public string SearchNodeTenme(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.hoTen, name) == 0)
                    return root.info.me;
                else if (string.Compare(root.info.hoTen, name) == 1)
                    return SearchNodeTenme(root.pLeft, name);
                return SearchNodeTenme(root.pRight, name);
            }
            return null;
        }
    }
}