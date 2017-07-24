using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class BinaryTree
    {
        public TreeNode<int> Root { get; set; }

        public BinaryTree()
        {
            
        }

        public void FillTreeNodesWithStaticData()
        {
            //    1
            //   8 9
            //  1 5 9
            // 4 5 2 3

            // 1
            Root = new TreeNode<int>(1);
            Root.LeftNode = new TreeNode<int>(8);
            Root.RightNode = new TreeNode<int>(9);

            // 8
            Root.LeftNode.LeftNode = new TreeNode<int>(1);
            Root.LeftNode.RightNode = new TreeNode<int>(5);

            // 9
            Root.RightNode.LeftNode = new TreeNode<int>(5);
            Root.RightNode.RightNode = new TreeNode<int>(9);

            // 1
            Root.LeftNode.LeftNode.LeftNode = new TreeNode<int>(4);
            Root.LeftNode.LeftNode.RightNode = new TreeNode<int>(5);

            // 5
            Root.LeftNode.RightNode.LeftNode = new TreeNode<int>(5);
            Root.LeftNode.RightNode.RightNode = new TreeNode<int>(2);

            // 5
            Root.RightNode.LeftNode.LeftNode = new TreeNode<int>(5);
            Root.RightNode.LeftNode.RightNode = new TreeNode<int>(2);

            // 5
            Root.RightNode.RightNode.LeftNode = new TreeNode<int>(2);
            Root.RightNode.RightNode.RightNode = new TreeNode<int>(3);
        }
    }
}
