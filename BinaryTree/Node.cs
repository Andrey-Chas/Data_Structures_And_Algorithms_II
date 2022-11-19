using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node LeftData;
        public Node RightData;
        public int Number;

        public Node(int number)
        {
            Number = number;
        }

        public void Add(int value)
        {

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
