using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emara.CustomTypes;

namespace Emara.CodingTest.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void CalculateMaxSum()
        {
            // Prepare
            var input = new BinaryTree();
            input.FillTreeNodesWithStaticData();

            // Act
            var maxSum = Algorithm.CalculateMaxSum(input);

            // Assert
            Assert.AreEqual(maxSum, 16);
        }
    }
}
