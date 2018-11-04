using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGP
{
    public class StructTree
    {
        private int keyID, theHe;
        public int Key
        {
            get { return keyID; }
            set { keyID = value; }
        }
        public int TheHe
        {
            get { return theHe; }
            set { theHe = value; }
        }
        private string hoTen, cha, me, tenVoChong, tenCon;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string tenCha
        {
            get { return cha; }
            set { cha = value; }
        }
        public string tenMe
        {
            get { return me; }
            set { me = value; }
        }
        public string TenVoChong
        {
            get { return tenVoChong; }
            set { tenVoChong = value; }
        }
        public string TenCon
        {
            get { return tenCon; }
            set { tenCon = value; }
        }
        private bool gioiTinh = true, thuocGP = true; //true = nam, true = có trong gia phả
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public bool ThuocGP
        {
            get { return thuocGP; }
            set { thuocGP = value; }
        }
        private string namSinh, namMat;
        public string NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public string NamMat
        {
            get { return namMat; }
            set { namMat = value; }
        }
        private string noiSinh, ngheNghiep;
        public string NoiSinh
        {
            get { return noiSinh; }
            set { noiSinh = value; }
        }
        public string NgheNghiep
        {
            get { return ngheNghiep; }
            set { ngheNghiep = value; }
        }
    }
    public class Node
    {
        StructTree info;
        Node pLeft;
        Node pRight;
    }

}