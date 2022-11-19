using System;
using System.Collections.Generic;
using System.Text;

namespace Departments
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public string ManagerName { get; set; }
        public int NumberOfEmployees { get; set; }

        public override string ToString()
        {
            return $"Department name: {DepartmentName}, Manager name: {ManagerName}, Number of employees: {NumberOfEmployees}";
        }
    }
}
