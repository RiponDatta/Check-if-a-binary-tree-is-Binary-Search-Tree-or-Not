using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBSTOrNot
{
    public class BinaryTree
    {
        public Node Root;
  
        public bool IsBinarySeachTree()
        {
            return IsBinarySeachTree(Root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySeachTree(Node root, int min, int max)
        {
            if(root == null)
            {
                return true;
            }

            if(root.Data < min || root.Data > max)
            {
                return false;
            }

            return IsBinarySeachTree(root.Left, min, root.Data - 1) && IsBinarySeachTree(root.Right, root.Data + 1, max);
        }
    }
}
