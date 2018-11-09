using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections;

namespace TestingGP
{
    public class GIAPHA
    {
        public int keyID, theHe, parent;
        public string hoTen, cha, me, tenVoChong, tenCon;
        public bool gioiTinh = true, thuocGP = true; //true = nam, true = có trong gia phả
        public string namSinh, namMat;
        public string noiSinh, ngheNghiep;
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
            if (pHead == null)
            {
                pHead = pTail = p;
            }
            else
            {
                pTail.pNext = p;
                p.pNext = null;
                pTail = p;
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
           // gp.keyID=
        }
    }

    /*
    public class BinaryTree
    {
        public class Node
        {
            public int key;
            public GIAPHA info;
            public Node pLeft;
            public Node pRight;
        }
        public BinaryTree(Node t)
        {
            t = null;
        }
        Node CreateNode(GIAPHA t, int x)
        {
            Node p = new Node();
            if (p != null)
            {
                p.key = x;
                p.info = t;
                p.pLeft = p.pRight = null;
            }
            else MessageBox.Show("Không đủ bộ nhớ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return p;
        }
        void AddNode(Node t, GIAPHA gp, int x)
        {
            if (t != null)
            {
                if (t.key == x)
                {
                    MessageBox.Show("Nút này đã có trong cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (t.key > x)
                {
                    AddNode(t.pLeft, gp, x);
                    t.key = x;
                }
                else
                {
                    AddNode(t.pRight, gp, x);
                    t.key = x;
                }
            }
            else //chưa có phần tử nào
            {
                t = new Node();
                if (t == null)
                {
                    MessageBox.Show("không đủ bộ nhớ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                t = CreateNode(gp, x);
            }
        }
       // void CreateTree()
    }
    */
}