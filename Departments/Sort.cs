using System;
using System.Collections.Generic;
using System.Text;

namespace Departments
{
    class SortByNumberOfEmployees : IComparer<Department>
    {
        public int Compare(Department x, Department y)
        {
            return x.NumberOfEmployees.CompareTo(y.NumberOfEmployees);
        }
    }
}
