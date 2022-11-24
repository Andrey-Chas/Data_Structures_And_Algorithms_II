using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node Root;
        public Node LeftData;
        public Node RightData;
        public int Number;

        public Node(int number)
        {
            Number = number;
        }

        //public void Add(int value)
        //{
        //    Node newNode = new Node();
        //    newNode.Number = value;

        //    if (Root != null)
        //    {
        //        if (newNode.Number > Root.Number)
        //        {
        //            if (Root.RightData == null)
        //            {
        //                Root.RightData = newNode;
        //            }
        //            else
        //            {
        //                Root.RightData.Add(value);
        //            }
        //        }
        //        else if (newNode.Number < Root.Number)
        //        {
        //            if (Root.LeftData == null)
        //            {
        //                Root.LeftData = newNode;
        //            }
        //            else
        //            {
        //                Root.LeftData.Add(value);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Root = newNode;
        //    }
        //}

        public void Sort(Node root)
        {
            if (root != null)
            {
                Sort(root.LeftData);
                Console.Write(root.Number + " ");
                Sort(root.RightData);
            }
        }

        public Node FindNumber(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Number)
                {
                    return parent;
                }
                if (value < parent.Number)
                {
                    return FindNumber(value, parent.LeftData);
                }
                else
                {
                    return FindNumber(value, parent.RightData);
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"{Number}";
        }
    }
}
