using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode<T> RightNode { get; set; }

        public TreeNode<T> LeftNode { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }      
    }
}
