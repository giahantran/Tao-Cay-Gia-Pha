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
        //
        //Hàm tìm kiếm thế hệ
        public GIAPHA SearchNodeTheHe(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.theHe.ToString(), name) == 0)
                    return root.info;
                else if (string.Compare(root.info.theHe.ToString(), name) == 1) //trái lớn hơn phải
                    return SearchNodeTheHe(root.pLeft, name);
                return SearchNodeTheHe(root.pRight, name);                           //trái nhỏ hơn phải
            }
            return null;
        }
        //Hàm tìm kiếm ông bà
        public int SearchNodeOngba(Node root, string name)
        {
            if (root != null)
            {

                if (string.Compare(root.info.hoTen.ToString(), name) == 0)
                    return root.info.theHe;
                else if (string.Compare(root.info.hoTen.ToString(), name) == 1) //trái lớn hơn phải
                    return SearchNodeOngba(root.pLeft, name);
                else
                {
                    return SearchNodeOngba(root.pRight, name);                           //trái nhỏ hơn phải
                }

            }
            return 0;
        }


        public Node SearchNodeOngBaTui(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.theHe.ToString(), name) == 0)
                    return root;
                else if (string.Compare(root.info.theHe.ToString(), name) == 1) //trái lớn hơn phải
                    return SearchNodeOngBaTui(root.pLeft, name);
                return SearchNodeOngBaTui(root.pRight, name);                           //trái nhỏ hơn phải
            }
            return null;
        }
        //Hàm xuất những người thuộc gia phả
        public GIAPHA SearchNodeThuocGP(Node root, string name)
        {
            if (root != null)
            {
                if (string.Compare(root.info.thuocGP.ToString(), name) == 0)
                    return root.info;
                else if (string.Compare(root.info.thuocGP.ToString(), name) == 1) //trái lớn hơn phải
                    return SearchNodeThuocGP(root.pLeft, name);
                return SearchNodeThuocGP(root.pRight, name);                           //trái nhỏ hơn phải
            }
            return null;
        }
        //Hàm sắp xếp heo ID
        public GIAPHA SearchNodeID(Node root, string name)
        {

            if (root != null)
            {
                if (string.Compare(root.info.iD.ToString(), name) == 0)
                    return root.info;
                else if (string.Compare(root.info.thuocGP.ToString(), name) == 1) //trái lớn hơn phải
                    return SearchNodeID(root.pLeft, name);
                return SearchNodeID(root.pRight, name);                           //trái nhỏ hơn phải
            }
            return null;
        }


    }
}