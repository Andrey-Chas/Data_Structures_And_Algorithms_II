using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
