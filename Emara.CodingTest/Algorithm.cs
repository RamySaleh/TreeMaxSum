using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CodingTest
{
    public class Algorithm
    {
        public static int CalculateMaxSum(BinaryTree tree)
        {
            var max = CalculateTreeMax(tree.Root, 0, tree.Root.IsEven, 0);

            return max;
        }

        //    1
        //   8 9
        //  1 5 9
        // 4 5 2 3
        private static int CalculateTreeMax(TreeNode root, int currentMax, bool isPrevEven, int max)
        {
            currentMax += root.Value;

            if (root.LeftNode != null && root.LeftNode.IsEven != isPrevEven)
            {
                max = CalculateTreeMax(root.LeftNode, currentMax, root.LeftNode.IsEven, max);
            }

            if (root.RightNode != null && root.RightNode.IsEven != isPrevEven)
            {
                max = CalculateTreeMax(root.RightNode, currentMax, root.RightNode.IsEven, max);
            }

            if (currentMax > max)
            {
                max = currentMax;
            }

            return max;
        }
    }
}
