using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class TreeNode
    {
        public int Value { get; set; }

        public TreeNode RightNode { get; set; }

        public TreeNode LeftNode { get; set; }

        public bool IsEven
        {
            get
            {
                return Value % 2 == 0;
            }
        }

        public TreeNode(int value)
        {
            Value = value;
        }
    }
}
