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
        public static int CalculateMaxSum(int[][] data)
        {
            var max = 0;
            if (data.Length > 0 && data[0].Length > 0)
            {
                max = CalculateTreeMax(data, 0, 0, 0, data[0][0].IsEven(), 0);
            }

            return max;
        }

        private static int CalculateTreeMax(int[][] data, int i, int j, int currentMax, bool isPrevEven, int max)
        {
            currentMax += data[i][j];

            if (i + 1 < data.Length)
            {
                var leftNode = data[i + 1][j];
                if (leftNode.IsEven() != isPrevEven)
                {
                    max = CalculateTreeMax(data, i + 1, j, currentMax, leftNode.IsEven(), max);
                }
            }
            
            if (i + 1 < data.Length && j + 1 < data[i+1].Length)
            {
                var rightNode = data[i + 1][j + 1];
                if (rightNode.IsEven() != isPrevEven)
                {
                    max = CalculateTreeMax(data, i + 1, j + 1, currentMax, rightNode.IsEven(), max);
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
