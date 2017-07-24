using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CustomTypes
{
    public class BinaryTree
    {
        private int[][] _data;

        public int? Root
        {
            get
            {
                if (_data.Length > 0 && _data[0].Length > 0)
                {
                    return _data[0][0];
                }
                return null;
            }
        }

        public BinaryTree(int[][] data)
        {
            _data = data;
        }

        public int? GetValue(int i, int j)
        {
            return _data[i][j];
        }

        public int? LeftNode(int i, int j)
        {
            if (i + 1 < _data.Length && j < _data[i + 1].Length)
            {
                return _data[i + 1][j];
            }
            return null;
        }

        public int? RightNode(int i, int j)
        {
            if (i + 1 < _data.Length && j + 1 < _data[i + 1].Length)
            {
                return _data[i + 1][j + 1];
            }
            return null;
        }
    }
}
