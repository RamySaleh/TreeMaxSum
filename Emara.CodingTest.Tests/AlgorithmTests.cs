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
            //    1
            //   8 9
            //  1 5 9
            // 4 5 2 3

            // Prepare
            //BinaryTree inputTree = SampleData.FillTreeNodesWithStaticData_Sample1();
            int[][] triangle = new int[][] {  new int[] {1, 0, 0,0},
                      new int[] {8, 9, 0,0},
                      new int[] {1, 5, 9,0},
                      new int[] {4, 5, 2 , 3}
            };

            // Act
            var maxSum = Algorithm.CalculateMaxSum(triangle);

            // Assert
            Assert.AreEqual(16, maxSum);
        }

        [TestMethod]
        public void CalculateMaxSum_Test2()
        {
            // Prepare
            BinaryTree inputTree = SampleData.FillTreeNodesWithStaticData_Sample2();

            // Act
            var maxSum = Algorithm.CalculateMaxSum(inputTree);

            // Assert
            Assert.AreEqual(20, maxSum);
        }

        [TestMethod]
        public void CalculateMaxSum_Test3_Big()
        {
            // Prepare
            var inputData = SampleData.GetSampleData();

            // Act
            var maxSum = Algorithm.CalculateMaxSum(inputData);

            // Assert
            Assert.AreEqual(8186, maxSum);
        }
    }
}
