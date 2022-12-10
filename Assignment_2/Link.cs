using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Link
    {
        public string Node1;
        public string Node2;
        public double Distance;
        public double Speed;

        public Link (string node1, string node2, double distance, double speed)
        {
            Node1 = node1;
            Node2 = node2;
            Distance = distance;
            Speed = speed;
        }
    }
}
