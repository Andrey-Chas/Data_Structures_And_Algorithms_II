using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tree = CreateTree();
            List<Person> result = new List<Person>();
            List<Person> resultQ = new List<Person>();
            Queue<Person> queueOfPersons = new Queue<Person>();
            queueOfPersons.Enqueue(tree);
            Console.WriteLine(tree.GetTheChildrenCount());
            Console.WriteLine(tree.GetTheNumberOfDescendants());
            Console.WriteLine(tree.GetPersonByName("Kate"));
            tree.GetAllPersonsByName("Kate", result);
            foreach (Person nameNeeded in result)
            {
                Console.WriteLine(nameNeeded);
            }
            // Console.WriteLine(tree.GetPersonByNameQ("Kate", queueOfPersons));
            tree.GetAllPersonsByNameQ("Sally", resultQ, queueOfPersons);
            foreach (Person nameNeeded in resultQ)
            {
                Console.WriteLine(nameNeeded);
            }
        }

        public static Person CreateTree()
        {
            Person root = new Person("Jack", 'M', 1920);
            Person Lilly = new Person("Sally", 'F', 1948);
            root.Children.Add(Lilly);
            Person Tom = new Person("Tom", 'M', 1950);
            root.Children.Add(Tom);
            Person Sally = new Person("Sally", 'F', 1970);
            Lilly.Children.Add(Sally);
            Person Jason = new Person("Jason", 'M', 1971);
            Lilly.Children.Add(Jason);
            Person Luke = new Person("Luke", 'M', 1976);
            Lilly.Children.Add(Luke);
            Person Kate = new Person("Kate", 'F', 1977);
            Tom.Children.Add(Kate);

            return root;
        }
    }
}
