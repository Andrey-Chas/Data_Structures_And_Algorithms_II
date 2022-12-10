using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Link
    {
        public String Node1;
        public String Node2;
        public int Cost;


        public Link(String node1, String node2, int cost)
        {
            Node1 = node1;
            Node2 = node2;
            Cost = cost;
        }

        public String GetOther(String node)
        {
            if (Node1 == node)
            {
                return Node2;
            }
            else if (Node2 == node)
            {
                return Node1;
            }
            return null;
        }

    }
}
