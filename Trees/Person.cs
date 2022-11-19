using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Person
    {
        public string Name;
        public char Gender;
        public int YOB;
        public List<Person> Children = new List<Person>();

        public Person(string name, char gender, int yob)
        {
            Name = name;
            Gender = gender;
            YOB = yob;
        }

        public int GetTheChildrenCount()
        {
            return Children.Count;
        }

        public int GetTheNumberOfDescendants()
        {
            int result = 1;
            foreach (Person child in Children)
            {
                result += child.GetTheNumberOfDescendants();
            }
            return result;
        }

        public Person GetPersonByName(string name)
        {
            if (name == this.Name)
            {
                return this;
            }

            foreach (Person child in Children)
            {
                Person p = child.GetPersonByName(name);
                if (child.GetPersonByName(name) != null)
                {
                    return p;
                }
            }
            return null;
        }

        public void GetAllPersonsByName(string name, List<Person> result)
        {
            if (name == this.Name)
            {
                result.Add(this);
            }

            foreach (Person child in Children)
            {
                child.GetAllPersonsByName(name, result);
            }
        }

        public Person GetPersonByNameQ(string name, Queue<Person> queueOfChildren)
        {
            while (queueOfChildren.Count != 0)
            {
                Person p = queueOfChildren.Dequeue();
                if (name == p.Name)
                {
                    return p;
                }
                foreach (Person child in p.Children)
                {
                    queueOfChildren.Enqueue(child);
                }
            }
            return null;
        }

        public void GetAllPersonsByNameQ(string name, List<Person> result, Queue<Person> queueOfChildren)
        {
            while (queueOfChildren.Count != 0)
            {
                Person p = queueOfChildren.Dequeue();
                if (name == p.Name)
                {
                    result.Add(p);
                }
                foreach (Person child in p.Children)
                {
                    queueOfChildren.Enqueue(child);
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Year of Birth: {YOB}";
        }
    }
}
