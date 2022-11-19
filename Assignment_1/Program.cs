using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company data = new Company("Advance to the future");
            data = data.CreateData();

            while (true)
            {
                Console.Clear();
                DispalyMenu();

                string userIn = Console.ReadLine();

                while (userIn != "1" && userIn != "2" && userIn != "3" && userIn != "4" && userIn != "5" && userIn != "6" && userIn != "7" && userIn != "8" && userIn != "9" && userIn != "10" && userIn != "11" && userIn != "0")
                {
                    Console.Write("This option does not exist. Choose an existing one: ");
                    userIn = Console.ReadLine();
                }

                if (userIn == "1")
                {
                    GetTheDepartments(data);
                }
                else if (userIn == "2")
                {
                    GetTheEmployee(data);
                }
                else if (userIn == "3")
                {
                    GetTheSubDepartments(data);
                }
                else if (userIn == "4")
                {
                    AddSubDepartment(data);
                }
                else if (userIn == "5")
                {
                    AddEmployee(data);
                }
                else if (userIn == "6")
                {
                    RemoveSubDepartment(data);
                }
                else if (userIn == "7")
                {
                    RemoveEmployee(data);
                }
                else if (userIn == "8")
                {
                    MoveSubDepartment(data);
                }
                else if (userIn == "9")
                {
                    MoveEmployee(data);
                }
                else if (userIn == "10")
                {
                    GetTheNumberOfSubDepartments(data);
                }
                else if (userIn == "11")
                {
                    GetTheNumberOfEmployee(data);
                }
                else if (userIn == "0")
                {
                    break;
                }
            }
        }

        private static void DispalyMenu()
        {
            Console.WriteLine("ADVANCETOTHEFUTURE INFORMATION");
            Console.WriteLine("\n\t1. View departments");
            Console.WriteLine("\n\t2. View employee of the department");
            Console.WriteLine("\n\t3. View sub-departments of the department");
            Console.WriteLine("\n\t4. Add new sub-department");
            Console.WriteLine("\n\t5. Add new employee");
            Console.WriteLine("\n\t6. Remove sub-department");
            Console.WriteLine("\n\t7. Remove employee");
            Console.WriteLine("\n\t8. Move sub-department");
            Console.WriteLine("\n\t9. Move employee");
            Console.WriteLine("\n\t10. Get the number of sub-departments");
            Console.WriteLine("\n\t11. Get the number of employee");
            Console.WriteLine("\n\t0. Exit");
            Console.Write("\nType the number of the option you would like to choose or type 0 to exit: ");
        }

        private static void GetTheDepartments(Company data)
        {
            Console.Clear();
            Console.WriteLine("THE LIST OF DEPARTMENTS");
            Console.WriteLine();
            data.GetTheDepartments();
            PressAnyKeyToContinue();
        }

        private static void GetTheEmployee(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("THE LIST OF EMPLOYEE");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("THE LIST OF EMPLOYEE");
                Console.WriteLine();
                ListEmployee(data, verified);
                PressAnyKeyToContinue();
            }
        }

        private static void GetTheSubDepartments(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("THE LIST OF SUBDEPARTMENTS");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("THE LIST OF SUBDEPARTMENTS");
                Console.WriteLine();
                ListSubDepartments(data, verified);
                PressAnyKeyToContinue();
            }
        }

        private static void AddSubDepartment(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ADD NEW SUBDEPARTMENT");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("ADD NEW SUBDEPARTMENT");
                Console.WriteLine();
                Console.Write("Please type the name of sub-department: ");
                string name = Console.ReadLine();
                Console.Write("Please type the name of sub-department manager: ");
                string subDepartmentManager = Console.ReadLine();
                Department departmentToAdd = data.AddRemove(verified.ToLower());
                Department newDepartment = new Department(name, subDepartmentManager);
                departmentToAdd.SubDepartments.Add(newDepartment);
                Console.Clear();
                Console.WriteLine("ADD NEW SUBDEPARTMENT");
                Console.WriteLine();
                Console.WriteLine($"The sub-department with the name {name} was successfully\nadded to the department {verified}");
                PressAnyKeyToContinue();
            }
        }

        private static void AddEmployee(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ADD NEW EMPLOYEE");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("ADD NEW EMPLOYEE");
                Console.WriteLine();
                Console.Write("Please type the name of employee: ");
                string name = Console.ReadLine();
                Console.Write("Please type the gender of employee: ");
                string gender = Console.ReadLine();
                Department departmentToAdd = data.AddRemove(verified.ToLower());
                Person newEmployee = new Person(name, gender);
                departmentToAdd.Employee.Add(newEmployee);
                Console.Clear();
                Console.WriteLine("ADD NEW EMPLOYEE");
                Console.WriteLine();
                Console.WriteLine($"The employee with the name {name} was successfully\nadded to the department {verified}");
                PressAnyKeyToContinue();
            }
        }

        private static void RemoveSubDepartment(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("REMOVE SUBDEPARTMENT");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("REMOVE SUBDEPARTMENT");
                Console.WriteLine();
                bool value = ListSubDepartments(data, verified);
                if (value == false)
                {
                    PressAnyKeyToContinue();
                    break;
                }
                Console.WriteLine();
                Console.Write("Please choose the sub-department you would like to remove by typing\nthe name: ");
                string subDepartmentValue = "";
                userIn = Console.ReadLine();
                subDepartmentValue = SubDepartmentVerification(data, subDepartmentValue, verified, userIn);
                Console.Clear();
                Console.WriteLine("REMOVE SUBDEPARTMENT");
                Console.WriteLine();
                Console.WriteLine($"The sub-department with the name {subDepartmentValue} was successfully\nremoved from the department {verified}");
                PressAnyKeyToContinue();
            }
        }

        private static void RemoveEmployee(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("REMOVE EMPLOYEE");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("REMOVE EMPLOYEE");
                Console.WriteLine();
                bool value = ListEmployee(data, verified);
                if (value == false)
                {
                    PressAnyKeyToContinue();
                    break;
                }
                Console.WriteLine();
                Console.Write("Please choose the employee you would like to remove by typing\nthe name: ");
                string employeeValue = "";
                userIn = Console.ReadLine();
                employeeValue = EmployeeVerification(data, employeeValue, verified, userIn);
                Console.Clear();
                Console.WriteLine("REMOVE EMPLOYEE");
                Console.WriteLine();
                Console.WriteLine($"The employee with the name {employeeValue} was successfully\nremoved from the department {verified}");
                PressAnyKeyToContinue();
            }
        }

        private static void MoveSubDepartment(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MOVE SUBDEPARTMENT");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("MOVE SUBDEPARTMENT");
                Console.WriteLine();
                bool value = ListSubDepartments(data, verified);
                if (value == false)
                {
                    PressAnyKeyToContinue();
                    break;
                }
                Console.WriteLine();
                Console.Write("Please choose the sub-deprtment you would like to move by typing\nthe name: ");
                Department subDepartmentValue = null;
                userIn = Console.ReadLine();
                List<Department> subDepartments = data.GetTheSubDepartments(verified.ToLower());
                while (true)
                {
                    value = false;
                    foreach (Department subDepartment in subDepartments)
                    {
                        if (userIn.ToLower() == subDepartment.Name.ToLower())
                        {
                            value = true;
                            subDepartmentValue = subDepartment;
                            break;
                        }
                    }
                    if (value == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("This sub-department does not exist. Please choose an existing one: ");
                        userIn = Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("MOVE SUBDEPARTMENT");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name where you would like to move\nthe sub-department: ");
                string subDepartmentValueStr = "";
                isNeeded = false;
                subDepartmentValueStr = SubDepartmentVerification(data, subDepartmentValueStr, verified, userIn);
                userIn = Console.ReadLine();
                string verififedToMove = Verification(data, departmentValue, userIn, isNeeded);
                Department departmentToMove = data.AddRemove(verififedToMove.ToLower());
                departmentToMove.SubDepartments.Add(subDepartmentValue);
                Console.Clear();
                Console.WriteLine("MOVE SUBDEPARTMENT");
                Console.WriteLine();
                Console.WriteLine($"The sub-department with the name {subDepartmentValueStr} was successfully\nmoved from department {verified} to department {verififedToMove}");
                PressAnyKeyToContinue();
            }
        }

        private static void MoveEmployee(Company data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MOVE EMPLOYEE");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name or type 0 to exit: ");
                string departmentValue = "";
                bool isNeeded = true;
                string userIn = Console.ReadLine();
                if (userIn == "0")
                {
                    break;
                }
                string verified = Verification(data, departmentValue, userIn, isNeeded);
                if (verified == "0")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("MOVE EMPLOYEE");
                Console.WriteLine();
                bool value = ListEmployee(data, verified);
                if (value == false)
                {
                    PressAnyKeyToContinue();
                    break;
                }
                Console.WriteLine();
                Console.Write("Please choose the employee you would like to move by typing\nthe name: ");
                Person person1 = null;
                userIn = Console.ReadLine();
                List<Person> employee = data.GetTheEmployee(verified.ToLower());
                while (true)
                {
                    value = false;
                    foreach (Person person in employee)
                    {
                        if (userIn.ToLower() == person.Name.ToLower())
                        {
                            value = true;
                            person1 = person;
                            break;
                        }
                    }
                    if (value == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("This employee does not exist. Please choose an existing one: ");
                        userIn = Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("MOVE EMPLOYEE");
                Console.WriteLine();
                data.GetTheDepartments();
                Console.WriteLine();
                Console.Write("Please choose the department by typing the name where you would like to move\nthe employee: ");
                string employeeValueStr = "";
                isNeeded = false;
                employeeValueStr = EmployeeVerification(data, employeeValueStr, verified, userIn);
                userIn = Console.ReadLine();
                string verifiedToMove = Verification(data, departmentValue, userIn, isNeeded);
                Department departmentToMove = data.AddRemove(verifiedToMove.ToLower());
                departmentToMove.Employee.Add(person1);
                Console.Clear();
                Console.WriteLine("MOVE EMPLOYEE");
                Console.WriteLine();
                Console.WriteLine($"The employee with the name {employeeValueStr} was successfully\nmoved from department {verified} to department {verifiedToMove}");
                PressAnyKeyToContinue();
            }
        }

        private static void GetTheNumberOfSubDepartments(Company data)
        {
            Console.Clear();
            Console.WriteLine("GET THE NUMBER OF SUBDEPARTMENTS");
            Console.WriteLine();
            int number = data.GetTheNumberOfSubDepartments();
            Console.WriteLine($"There is a total amount of {number} sub-departments");
            PressAnyKeyToContinue();
        }

        private static void GetTheNumberOfEmployee(Company data)
        {
            Console.Clear();
            Console.WriteLine("GET THE NUMBER OF EMPLOYEE");
            Console.WriteLine();
            int number = data.GetTheNumberOfEmployee();
            Console.WriteLine($"There is a total amount of {number} employee");
            PressAnyKeyToContinue();
        }

        private static string Verification(Company data, string departmentValue, string userIn, bool isNeeded)
        {
            while (true)
            {
                bool value = false;
                foreach (Department department in data.Departments)
                {
                    if (userIn.ToLower() == department.Name.ToLower())
                    {
                        value = true;
                        departmentValue = department.Name;
                        break;
                    }
                }
                if (value == true)
                {
                    return departmentValue;
                }
                else if (isNeeded == true)
                {
                    Console.Write("This department does not exist.\nPlease type an existing one or type 0 to exit: ");
                    userIn = Console.ReadLine();
                }
                else if (isNeeded == false)
                {
                    Console.Write("This department does not exist. Please type an existing one: ");
                    userIn = Console.ReadLine();
                }
                if (userIn == "0" && isNeeded == true)
                {
                    return userIn;
                }
            }
        }

        private static bool ListEmployee(Company data, string verified)
        {
            bool value = true;
            List<Person> employee = data.GetTheEmployee(verified.ToLower());
            if (employee.Count > 0)
            {
                Console.WriteLine($"Employee from {verified} department are:");
                foreach (Person person in employee)
                {
                    Console.WriteLine(person.Name);
                }
            }
            else
            {
                value = false;
                Console.WriteLine($"{verified} department does not have employee");
            }
            return value;
        }

        private static bool ListSubDepartments(Company data, string verified)
        {
            bool value = true;
            List<Department> subDepartments = data.GetTheSubDepartments(verified.ToLower());
            if (subDepartments.Count > 0)
            {
                Console.WriteLine($"Sub-department from {verified} department are:");
                foreach (Department subDepartment in subDepartments)
                {
                    Console.WriteLine(subDepartment);
                }
            }
            else
            {
                value = false;
                Console.WriteLine($"{verified} department does not have sub-departments");
            }
            return value;
        }

        private static string SubDepartmentVerification(Company data, string subDepartmentValue, string verified, string userIn)
        {
            List<Department> subDepartments = data.GetTheSubDepartments(verified.ToLower());
            while (true)
            {
                bool value = false;
                foreach (Department subDepartment in subDepartments)
                {
                    if (userIn.ToLower() == subDepartment.Name.ToLower())
                    {
                        value = true;
                        subDepartmentValue = subDepartment.Name;
                        Department departmentToRemove = data.AddRemove(verified.ToLower());
                        departmentToRemove.SubDepartments.Remove(subDepartment);
                        break;
                    }
                }
                if (value == true)
                {
                    return subDepartmentValue;
                }
                else
                {
                    Console.Write("This sub-department does not exist. Please choose an exsiting one: ");
                    userIn = Console.ReadLine();
                }
            }
        }

        private static string EmployeeVerification(Company data, string employeeValue, string verified, string userIn)
        {
            List<Person> employee = data.GetTheEmployee(verified.ToLower());
            while (true)
            {
                bool value = false;
                foreach (Person person in employee)
                {
                    if (userIn.ToLower() == person.Name.ToLower())
                    {
                        value = true;
                        employeeValue = person.Name;
                        Department departmentToRemove = data.AddRemove(verified.ToLower());
                        departmentToRemove.Employee.Remove(person);
                        break;
                    }
                }
                if (value == true)
                {
                    return employeeValue;
                }
                else
                {
                    Console.Write("This employee does not exist. Please choose an existing one: ");
                    userIn = Console.ReadLine();
                }
            }
        }

        private static void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
