using System;
using System.Collections.Generic;

namespace Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            Department department1 = new Department()
            {
                DepartmentName = "Planning",
                ManagerName = "John",
                NumberOfEmployees = 20
            };

            Department department2 = new Department()
            {
                DepartmentName = "Analysis",
                ManagerName = "Mary",
                NumberOfEmployees = 18
            };

            Department department3 = new Department()
            {
                DepartmentName = "Programming",
                ManagerName = "Jack",
                NumberOfEmployees = 10
            };

            Department department4 = new Department()
            {
                DepartmentName = "Economics",
                ManagerName = "Lucy",
                NumberOfEmployees = 14
            };

            Department department5 = new Department()
            {
                DepartmentName = "Data",
                ManagerName = "Tony",
                NumberOfEmployees = 23
            };

            Department department6 = new Department()
            {
                DepartmentName = "Shipping",
                ManagerName = "Amber",
                NumberOfEmployees = 10
            };

            Department department7 = new Department()
            {
                DepartmentName = "Stock",
                ManagerName = "Paul",
                NumberOfEmployees = 27
            };

            Department department8 = new Department()
            {
                DepartmentName = "Recruitment",
                ManagerName = "Lolla",
                NumberOfEmployees = 5
            };

            Department department9 = new Department()
            {
                DepartmentName = "Management",
                ManagerName = "Brody",
                NumberOfEmployees = 11
            };

            Department department10 = new Department()
            {
                DepartmentName = "Research",
                ManagerName = "Lilly",
                NumberOfEmployees = 19
            };
            
            departments.Add(department1);
            departments.Add(department2);
            departments.Add(department3);
            departments.Add(department4);
            departments.Add(department5);
            departments.Add(department6);
            departments.Add(department7);
            departments.Add(department8);
            departments.Add(department9);
            departments.Add(department10);

            foreach (var department in departments)
            {
                Console.WriteLine(department);
            }

            departments.Sort(new SortByNumberOfEmployees());
            Console.WriteLine();

            foreach (var department in departments)
            {
                Console.WriteLine(department);
            }
        }
    }
}
