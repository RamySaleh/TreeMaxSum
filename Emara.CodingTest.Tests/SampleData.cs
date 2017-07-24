using Emara.CustomTypes;
using System;
using System.Collections.Generic;
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

            // 1
            inputTree.Root = new TreeNode(1);
            inputTree.Root.LeftNode = new TreeNode(8);
            inputTree.Root.RightNode = new TreeNode(9);

            // 8
            inputTree.Root.LeftNode.LeftNode = new TreeNode(1);
            inputTree.Root.LeftNode.RightNode = new TreeNode(5);

            // 9
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
            inputTree.Root.RightNode.RightNode.RightNode = new TreeNode(3);

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
    }
}
