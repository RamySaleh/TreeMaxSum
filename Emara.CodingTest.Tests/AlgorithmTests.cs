using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emara.CustomTypes;

namespace Emara.CodingTest.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void CalculateMaxSum_Test1()
        {
            // Setup
            int[][] data = new int[][] {  new int[] {1},
                                          new int[] {8, 9},
                                          new int[] {1, 5, 9},
                                          new int[] {4, 5, 2, 3}
            };

            // Act
            var maxSum = TreeMaxSumAlgorithm.CalculateMaxSum(new BinaryTree(data));

            // Assert
            Assert.AreEqual(16, maxSum);
        }

        [TestMethod]
        public void CalculateMaxSum_Test2()
        {
            // Setup
            int[][] data = new int[][] {  new int[] {1},
                                          new int[] {8, 6},
                                          new int[] {1, 5, 9},
                                          new int[] {4, 5, 2, 4}
            };

            // Act
            var maxSum = TreeMaxSumAlgorithm.CalculateMaxSum(new BinaryTree(data));

            // Assert
            Assert.AreEqual(20, maxSum);
        }

        [TestMethod]
        public void CalculateMaxSum_Test3_Big()
        {
            // Setup
            var data = SampleDataHelper.GetDataFromFile(@"..\..\SampleData.txt");

            // Act
            var maxSum = TreeMaxSumAlgorithm.CalculateMaxSum(new BinaryTree(data));

            // Assert
            Assert.AreEqual(8186, maxSum);
        }
    }
}
