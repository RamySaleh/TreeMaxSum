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

        public static int CalculateMaxSum(int[][] triangle)
        {
            int[][] original = CloneArray(triangle);
            // loop for bottom-up calculation
            for (int i = triangle.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    // for each element, check both
                    // elements just below the number
                    // and below right to the number
                    // add the maximum of them to it
                    if (triangle[i + 1][j] > triangle[i + 1][j + 1] && IsDifferentPolarity(original[i][j], original[i + 1][j]))
                    {
                        triangle[i][j] += triangle[i + 1][j];
                    }
                    else
                    {
                        if (IsDifferentPolarity(original[i][j], original[i + 1][j + 1]))
                        {
                            triangle[i][j] += triangle[i + 1][j + 1];
                        }
                        else if(IsDifferentPolarity(original[i][j], original[i + 1][j]))
                        {
                            triangle[i][j] += triangle[i + 1][j];
                        }
                    }
                }
            }

            // return the top element
            // which stores the maximum sum
            return triangle[0][0];
        }

        private static bool IsDifferentPolarity(int first,int second)
        {
            return first % 2 != second % 2;
        }

        private static int[][] CloneArray(int[][] a)
        {
            int[][] b = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = new int[a[i].Length];
                Array.Copy(a[i], b[i], a[i].Length);
            }
            return b;
        }
    }
}
