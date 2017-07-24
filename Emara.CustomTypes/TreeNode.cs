using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class TreeNode
    {
        private int i;

        private int j;

        private int[][] data;

        public TreeNode(int[][] data, int i, int j)
        {
            this.data = data;
            this.i = i;
            this.j = j;
        }

        public int Value
        {
            get
            {
                return data[i][j];
            }
        }

        public TreeNode RightNode
        {
            get
            {
                if (i + 1 < data.Length && j + 1 < data[i + 1].Length)
                {
                    return new TreeNode(data, i + 1, j + 1);
                }
                return null;
            }
        }

        public TreeNode LeftNode
        {
            get
            {
                if (i + 1 < data.Length && j < data[i + 1].Length)
                {
                    return new TreeNode(data, i + 1, j);
                }
                return null;
            }
        }

        public bool IsEven
        {
            get
            {
                return Value % 2 == 0;
            }
        }       
    }
}
