using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CodingTest
{
    public class TreeMaxSumAlgorithm
    {
        public static int CalculateMaxSum(int[][] data)
        {
            var max = 0;
            if (data.Length > 0 && data[0].Length > 0)
            {
                max = CalculateTreeMax(data, 0, 0, 0, IsEven(data[0][0]), 0);
            }

            return max;
        }

        public static int CalculateTreeMax(int[][] data, int i, int j, int currentMax, bool isPrevEven, int max)
        {
            currentMax += data[i][j];

            if (i + 1 < data.Length)
            {
                var leftNode = data[i + 1][j];
                if (IsEven(leftNode) != isPrevEven)
                {
                    max = CalculateTreeMax(data, i + 1, j, currentMax, IsEven(leftNode), max);
                }
            }
            
            if (i + 1 < data.Length && j + 1 < data[i+1].Length)
            {
                var rightNode = data[i + 1][j + 1];
                if (IsEven(rightNode) != isPrevEven)
                {
                    max = CalculateTreeMax(data, i + 1, j + 1, currentMax, IsEven(rightNode), max);
                }
            }

            if (currentMax > max)
            {
                max = currentMax;
            }

            return max;
        }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
