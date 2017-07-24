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
            // Prepare
            BinaryTree inputTree = SampleData.FillTreeNodesWithStaticData_Sample1();

            // Act
            var maxSum = Algorithm.CalculateMaxSum(inputTree);

            // Assert
            Assert.AreEqual(maxSum, 16);
        }

        [TestMethod]
        public void CalculateMaxSum_Test2()
        {
            // Prepare
            BinaryTree inputTree = SampleData.FillTreeNodesWithStaticData_Sample2();

            // Act
            var maxSum = Algorithm.CalculateMaxSum(inputTree);

            // Assert
            Assert.AreEqual(maxSum, 20);
        }
    }
}
