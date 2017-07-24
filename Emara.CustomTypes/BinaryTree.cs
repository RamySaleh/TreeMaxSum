using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class BinaryTree
    {
        private int[][] data;

        public TreeNode Root { get; set; }

        public BinaryTree(int[][] data)
        {
            this.data = data;
            if (this.data.Length > 0 && this.data[0].Length > 0)
            {
                Root = new TreeNode(this.data, 0, 0);
            }
        }
    }
}
