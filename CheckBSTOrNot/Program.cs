using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBSTOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(10);
            tree1.Root.Left = new Node(8);
            tree1.Root.Right = new Node(2);
            tree1.Root.Left.Left = new Node(3);
            tree1.Root.Left.Right = new Node(5);
            tree1.Root.Right.Left = new Node(9);
            tree1.Root.Right.Right = new Node(10);
            tree1.Root.Right.Right.Right = new Node(16);

            var isBST = tree1.IsBinarySeachTree();
            Console.WriteLine(isBST);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(10);
            tree2.Root.Left = new Node(5);
            tree2.Root.Right = new Node(15);
            tree2.Root.Left.Left = new Node(2);
            tree2.Root.Left.Right = new Node(8);
            tree2.Root.Right.Right = new Node(20);

            isBST = tree2.IsBinarySeachTree();
            Console.WriteLine(isBST);
        }
    }
}
