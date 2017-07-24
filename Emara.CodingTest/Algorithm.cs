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
        static int _max;

        public static int CalculateMaxSum(BinaryTree tree)
        {
            CalculateTreeMax(tree.Root, 0, tree.Root.IsEven);

            return _max;
        }

        //    1
        //   8 9
        //  1 5 9
        // 4 5 2 3
        private static void CalculateTreeMax(TreeNode root, int currentMax, bool isPrevEven)
        {
            currentMax += root.Value;

            if (root.LeftNode != null && root.LeftNode.IsEven != isPrevEven)
            {
                CalculateTreeMax(root.LeftNode, currentMax, root.LeftNode.IsEven);
            }
            if (root.RightNode != null && root.RightNode.IsEven != isPrevEven)
            {
                CalculateTreeMax(root.RightNode, currentMax, root.RightNode.IsEven);
            }
            
            if (currentMax > _max)
            {
                _max = currentMax;
            }
        }
    }
}
