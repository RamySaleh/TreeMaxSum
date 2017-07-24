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
        public static int CalculateMaxSum(BinaryTree tree)
        {
            var max = 0;
            if (tree.Root.HasValue)
            {
                max = CalculateTreeMax(tree, 0, 0, 0, tree.Root.Value.IsEven(), 0);
            }

            return max;
        }

        private static int CalculateTreeMax(BinaryTree tree, int i, int j, int currentMax, bool isPrevEven, int max)
        {
            currentMax += tree.GetValue(i, j).Value;

            if (tree.LeftNode(i, j).HasValue)
            {
                if (tree.LeftNode(i, j).Value.IsEven() != isPrevEven)
                {
                    max = CalculateTreeMax(tree, i + 1, j, currentMax, tree.LeftNode(i, j).Value.IsEven(), max);
                }
            }

            if (tree.RightNode(i, j).HasValue)
            {
                if (tree.RightNode(i, j).Value.IsEven() != isPrevEven)
                {
                    max = CalculateTreeMax(tree, i + 1, j + 1, currentMax, tree.RightNode(i, j).Value.IsEven(), max);
                }
            }

            if (currentMax > max)
            {
                max = currentMax;
            }

            return max;
        }
    }
}
