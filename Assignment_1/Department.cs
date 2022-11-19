using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Department
    {
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Person> Employee { get; set; }
        public List<Department> SubDepartments { get; set; }

        public Department(string name, string managerName)
        {
            Name = name;
            ManagerName = managerName;
            Employee = new List<Person>();
            SubDepartments = new List<Department>();
        }

        public int GetTheSubDepartmentsCount()
        {
            return SubDepartments.Count;
        }

        public override string ToString()
        {
            return $"{Name}, Manager: {ManagerName}";
        }
    }
}
