using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class BinaryTree
    {
        private List<TreeNode> _leafs;
        public TreeNode Root { get; set; }

        public BinaryTree()
        {
            _leafs = new List<TreeNode>();
        }

        //    1
        //   8 9
        //  1 5 9
        // 4 5 2 3
        public void AddNode(int item)
        {
            if (Root == null)
            {
                Root = new TreeNode(item);
                _leafs.Clear();
                _leafs.Add(Root);
            }
            else
            {
                var added = false;
                var completedNodes = new List<TreeNode>();
           
                for (int i = 0; i < _leafs.Count(); i++)
                {
                    var leaf = _leafs[i];
                    if (leaf.LeftNode == null)
                    {
                        leaf.LeftNode = new TreeNode(item);
                        _leafs.Add(leaf.LeftNode);
                        added = true;
                        break;
                    }
                    else if (leaf.RightNode == null)
                    {
                        added = true;
                        leaf.RightNode = new TreeNode(item);
                        _leafs.Add(leaf.RightNode);
                        _leafs.Remove(leaf);
                        break;
                    }                                  
                }               
            }
        }        

        public void AddRow(int[] row)
        {

        }
    }
}
