using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CodingTest.Tests
{
    static class SampleData
    {
        public static BinaryTree FillTreeNodesWithStaticData_Sample1()
        {
            //    1
            //   8 9
            //  1 5 9
            // 4 5 2 3
            var inputTree = new BinaryTree();

            //var n = inputTree.AddNode(null,1);
            //inputTree.AddNode(n, 8);
            //inputTree.AddNode(n,9);
            //inputTree.AddNode(n,1);
            //inputTree.AddNode(n,5);
            //inputTree.AddNode(n,9);
            //inputTree.AddNode(n,4);
            //inputTree.AddNode(n,5);
            //inputTree.AddNode(n,2);
            //inputTree.AddNode(n, 3);
            //inputTree.AddRow(new int[] { 1 });
            //inputTree.AddRow(new int[] { 8,9 });
            //inputTree.AddRow(new int[] { 1, 5, 9 });
            //inputTree.AddRow(new int[] { 4, 5, 2, 3 });
            //// 1
            //inputTree.Root = new TreeNode(1);
            //inputTree.Root.LeftNode = new TreeNode(8);
            //inputTree.Root.RightNode = new TreeNode(9);

            //// 8
            //inputTree.Root.LeftNode.LeftNode = new TreeNode(1);
            //inputTree.Root.LeftNode.RightNode = new TreeNode(5);

            //// 9
            //inputTree.Root.RightNode.LeftNode = new TreeNode(5);
            //inputTree.Root.RightNode.RightNode = new TreeNode(9);

            //// 1
            //inputTree.Root.LeftNode.LeftNode.LeftNode = new TreeNode(4);
            //inputTree.Root.LeftNode.LeftNode.RightNode = new TreeNode(5);

            //// 5
            //inputTree.Root.LeftNode.RightNode.LeftNode = new TreeNode(5);
            //inputTree.Root.LeftNode.RightNode.RightNode = new TreeNode(2);

            //// 5
            //inputTree.Root.RightNode.LeftNode.LeftNode = new TreeNode(5);
            //inputTree.Root.RightNode.LeftNode.RightNode = new TreeNode(2);

            //// 5
            //inputTree.Root.RightNode.RightNode.LeftNode = new TreeNode(2);
            //inputTree.Root.RightNode.RightNode.RightNode = new TreeNode(3);

            return inputTree;
        }

        public static BinaryTree FillTreeNodesWithStaticData_Sample2()
        {
            //    1
            //   8 6
            //  1 5 9
            // 4 5 2 4
            var inputTree = new BinaryTree();

            // 1
            inputTree.Root = new TreeNode(1);
            inputTree.Root.LeftNode = new TreeNode(8);
            inputTree.Root.RightNode = new TreeNode(6);

            // 8
            inputTree.Root.LeftNode.LeftNode = new TreeNode(1);
            inputTree.Root.LeftNode.RightNode = new TreeNode(5);

            // 6
            inputTree.Root.RightNode.LeftNode = new TreeNode(5);
            inputTree.Root.RightNode.RightNode = new TreeNode(9);

            // 1
            inputTree.Root.LeftNode.LeftNode.LeftNode = new TreeNode(4);
            inputTree.Root.LeftNode.LeftNode.RightNode = new TreeNode(5);

            // 5
            inputTree.Root.LeftNode.RightNode.LeftNode = new TreeNode(5);
            inputTree.Root.LeftNode.RightNode.RightNode = new TreeNode(2);

            // 5
            inputTree.Root.RightNode.LeftNode.LeftNode = new TreeNode(5);
            inputTree.Root.RightNode.LeftNode.RightNode = new TreeNode(2);

            // 5
            inputTree.Root.RightNode.RightNode.LeftNode = new TreeNode(2);
            inputTree.Root.RightNode.RightNode.RightNode = new TreeNode(4);

            return inputTree;
        }

        public static int[][] GetSampleData()
        {
            var lines = File.ReadAllLines(@"..\..\SampleData.txt");

            int[][] data = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = Array.ConvertAll(lines[i].Split(' '), int.Parse);
            }
            return data;
        }
    }
}
