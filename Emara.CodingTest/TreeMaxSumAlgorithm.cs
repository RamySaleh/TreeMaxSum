using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Emara.CodingTest.Helpers;

namespace Emara.CodingTest
{
    public class TreeMaxSumAlgorithm
    {
        /// <summary>
        /// Calculate the max sum of all the paths in a tree
        /// </summary>
        /// <param name="tree">Input binary tree</param>
        /// <returns>Max sum</returns>
        public static int CalculateMaxSum(BinaryTree tree)
        {
            var max = 0;
            if (tree.Root != null)
            {
                max = CalculateTreeMax(tree.Root, 0, tree.Root.IsEven, 0);
            }

            return max;
        }

        private static int CalculateTreeMax(TreeNode treeNode, int currentMax, bool isPrevNodeEven, int max)
        {
            // Add the current node value to sum
            currentMax += treeNode.Value;

            // Go left if available
            if (treeNode.LeftNode != null && treeNode.LeftNode.IsEven != isPrevNodeEven)
            {
                max = CalculateTreeMax(treeNode.LeftNode, currentMax, treeNode.LeftNode.IsEven, max);
            }

            // Go right if available
            if (treeNode.RightNode != null && treeNode.RightNode.IsEven != isPrevNodeEven)
            {
                max = CalculateTreeMax(treeNode.RightNode, currentMax, treeNode.RightNode.IsEven, max);
            }

            // Find the max sum (if the current path sum > max sum then update the max sum)
            if (currentMax > max)
            {
                max = currentMax;
            }

            return max;
        }
    }
}
