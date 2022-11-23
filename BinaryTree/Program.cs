using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node binaryTree = new Node();
            binaryTree.Add(10);
            binaryTree.Add(18);
            binaryTree.Add(8);
            binaryTree.Add(15);
            binaryTree.Add(17);

            //Node binaryTree = CreateBinaryTree();
            Node neededNumber = binaryTree.FindNumber(28, binaryTree);
            if (neededNumber != null)
            {
                Console.WriteLine($"Found {neededNumber} in the tree");
            }
            else
            {
                Console.WriteLine("There is no such number in the tree");
            }
        }

        //private static Node CreateBinaryTree()
        //{
        //    Node root = new Node(50);

        //    Node lNum1 = new Node(32);
        //    Node rNum2 = new Node(68);

        //    root.LeftData = lNum1;
        //    root.RightData = rNum2;

        //    Node lNum3 = new Node(28);
        //    Node rNum4 = new Node(29);

        //    lNum1.LeftData = lNum3;
        //    lNum1.RightData = rNum4;

        //    Node lNum5 = new Node(57);
        //    Node rNum6 = new Node(63);

        //    rNum2.LeftData = lNum5;
        //    rNum2.RightData = rNum6;

        //    return root;
        //}
    }
}
