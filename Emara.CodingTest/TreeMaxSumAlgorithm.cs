using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emara.CodingTest.Helpers;

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
            if (tree.Root.HasValue)
            {
                max = CalculateTreeMax(tree, 0, 0, 0, tree.Root.Value.IsEven(), 0);
            }

            return max;
        }

        private static int CalculateTreeMax(BinaryTree tree, int i, int j, int currentMax, bool isPrevNodeEven, int max)
        {
            // Add the current node value to sum
            currentMax += tree.GetValue(i, j).Value;

            // Go left if available
            if (IsLeftPathAvailable(tree, i, j, isPrevNodeEven))
            {
                max = CalculateTreeMax(tree, i + 1, j, currentMax, tree.LeftNode(i, j).Value.IsEven(), max);
            }

            // Go right if available
            if (IsRightPathAvailable(tree, i, j, isPrevNodeEven))
            {
                max = CalculateTreeMax(tree, i + 1, j + 1, currentMax, tree.RightNode(i, j).Value.IsEven(), max);
            }

            // Find the max sum (if the current path sum > max sum then update the max sum)
            if (currentMax > max)
            {
                max = currentMax;
            }

            return max;
        }

        private static bool IsRightPathAvailable(BinaryTree tree, int i, int j, bool isPrevNodeEven)
        {
            return tree.RightNode(i, j).HasValue && tree.RightNode(i, j).Value.IsEven() != isPrevNodeEven;
        }

        private static bool IsLeftPathAvailable(BinaryTree tree, int i, int j, bool isPrevNodeEven)
        {
            return tree.LeftNode(i, j).HasValue && tree.LeftNode(i, j).Value.IsEven() != isPrevNodeEven;
        }
    }
}
