using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGP
{
    public class TreeMember
    {
        public int Value;
        public TreeMember Left;
        public TreeMember Right;

        public bool IsLeaf()
        {
            return Left == null && Right == null;
        }
    }
}
