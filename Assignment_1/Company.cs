using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public int GetTheDepartmentsCount()
        {
            return Departments.Count;
        }

        public List<Person> GetTheEmployee(string name)
        {
            foreach (Department department in Departments)
            {
                if (name == department.Name.ToLower())
                {
                    return department.Employee;
                }
            }
            return null;
        }

        public List<Department> GetTheSubDepartments(string name)
        {
            foreach (Department department in Departments)
            {
                if (name == department.Name.ToLower())
                {
                    return department.SubDepartments;
                }
            }
            return null;
        }

        public void GetTheDepartments()
        {
            int count = 1;
            foreach (Department department in Departments)
            {
                Console.WriteLine($"{count}. {department}");
                count++;
            }
        }

        public Department AddRemove(string name)
        {
            foreach (Department department in Departments)
            {
                if (name == department.Name.ToLower())
                {
                    return department;
                }
            }
            return null;
        }

        public int GetTheNumberOfSubDepartments()
        {
            int result = 0;
            foreach (Department department in Departments)
            {
                result += department.SubDepartments.Count;
            }
            return result;
        }

        public int GetTheNumberOfEmployee()
        {
            int result = 0;
            foreach (Department department in Departments)
            {
                result += department.Employee.Count;
            }
            return result;
        }

        public Company CreateData()
        {
            Company root = new Company("AdvanceToTheFuture");

            Department finances = new Department("Finances", "John Smith");
            Department accounting = new Department("Accounting", "Sarah Jane");
            Department salary = new Department("Salary", "Luke Brown");
            Department taxes = new Department("Taxes", "Paul Slave");
            Department fReports = new Department("Finance Report", "Lilly Flown");
            root.Departments.Add(finances);
            finances.SubDepartments.Add(accounting);
            finances.SubDepartments.Add(salary);
            finances.SubDepartments.Add(taxes);
            finances.SubDepartments.Add(fReports);
            finances.Employee.Add(new Person("Thurman Ballard", "Male"));
            finances.Employee.Add(new Person("Josefina Allison", "Female"));
            finances.Employee.Add(new Person("Kurt Spence", "Male"));
            finances.Employee.Add(new Person("Sid Donovan", "Male"));

            Department marketing = new Department("Marketing", "Lucinda Foster");
            Department planning = new Department("Planning", "Joanna Newman");
            Department marketResearch = new Department("Market Research", "Donny Townsend");
            Department selling = new Department("Selling", "Otto Gentry");
            Department trade = new Department("Trade", "Porfirio Mercado");
            root.Departments.Add(marketing);
            marketing.SubDepartments.Add(planning);
            marketing.SubDepartments.Add(marketResearch);
            marketing.SubDepartments.Add(selling);
            marketing.SubDepartments.Add(trade);
            marketing.Employee.Add(new Person("Sybil Leach", "Female"));
            marketing.Employee.Add(new Person("Beryl Davila", "Female"));
            marketing.Employee.Add(new Person("Santiago Wang", "Male"));
            marketing.Employee.Add(new Person("Beverley Morrison", "Female"));

            Department engineering = new Department("Engineering", "Dale Lucas");
            Department software = new Department("Software", "Caroline Mendoza");
            Department hardware = new Department("Hardware", "Miquel Weeks");
            Department buildingEngineers = new Department("Building Engineers", "Adriana Blake");
            Department eReports = new Department("Engineer Report", "George Meza");
            root.Departments.Add(engineering);
            engineering.SubDepartments.Add(software);
            engineering.SubDepartments.Add(hardware);
            engineering.SubDepartments.Add(buildingEngineers);
            engineering.SubDepartments.Add(eReports);
            engineering.Employee.Add(new Person("Jamel Kid", "Male"));
            engineering.Employee.Add(new Person("Jannie Cain", "Female"));
            engineering.Employee.Add(new Person("Fredrick Chase", "Male"));
            engineering.Employee.Add(new Person("Pat Wade", "Male"));

            Department programming = new Department("Programming", "Kim Norris");
            Department developers = new Department("Developers", "Chi Buckley");
            Department qualityAssurance = new Department("Quality Assurance", "Elwood Mcclure");
            Department lead = new Department("Lead", "Jere Gill");
            Department pReports = new Department("Programming Reports", "Kay Owen");
            root.Departments.Add(programming);
            programming.SubDepartments.Add(developers);
            programming.SubDepartments.Add(qualityAssurance);
            programming.SubDepartments.Add(lead);
            programming.SubDepartments.Add(pReports);
            programming.Employee.Add(new Person("Lelia Webb", "Female"));
            programming.Employee.Add(new Person("Trey Malone", "Male"));
            programming.Employee.Add(new Person("Johnnie Hammond", "Male"));
            programming.Employee.Add(new Person("Abel Bradford", "Male"));

            Department humanResource = new Department("Human Resource", "Julie Mills");
            Department recruitment = new Department("Recruitment", "Esperanza Newman");
            Department training = new Department("Training", "Otto Nash");
            Department internship = new Department("Internship", "Alonso Neal");
            Department humanResourceReport = new Department("Human Resource Report", "Leslie Pittman");
            root.Departments.Add(humanResource);
            humanResource.SubDepartments.Add(recruitment);
            humanResource.SubDepartments.Add(training);
            humanResource.SubDepartments.Add(internship);
            humanResource.SubDepartments.Add(humanResourceReport);
            humanResource.Employee.Add(new Person("Brooke Gamble", "Female"));
            humanResource.Employee.Add(new Person("Kris Mathews", "Female"));
            humanResource.Employee.Add(new Person("Deidre Meyer", "Female"));
            humanResource.Employee.Add(new Person("Darryl Palmer", "Male"));

            Department security = new Department("Security", "Mitchell Fuentes");
            Department buildingSecurity = new Department("Building Security", "Zachery Yang");
            Department internetSecurity = new Department("Internet Security", "Sam Waller");
            Department computerSecurity = new Department("Computer Security", "Millie Lin");
            Department sReports = new Department("Security Report", "Bradley Vaughn");
            root.Departments.Add(security);
            security.SubDepartments.Add(buildingSecurity);
            security.SubDepartments.Add(internetSecurity);
            security.SubDepartments.Add(computerSecurity);
            security.SubDepartments.Add(sReports);
            security.Employee.Add(new Person("Tristan Brock", "Male"));
            security.Employee.Add(new Person("Mitchell Orr", "Male"));
            security.Employee.Add(new Person("Gregorio Chen", "Male"));
            security.Employee.Add(new Person("Rolf Kim", "Male"));

            Department logistics = new Department("Logistics", "Jame Mcconnell");
            Department export = new Department("Export", "Laurence Curry");
            Department import = new Department("Import", "Lilly Humphrey");
            Department lSelling = new Department("Selling", "Wendi Hamilton");
            Department lReports = new Department("Logistics Report", "Christa Acosta");
            root.Departments.Add(logistics);
            logistics.SubDepartments.Add(export);
            logistics.SubDepartments.Add(import);
            logistics.SubDepartments.Add(lSelling);
            logistics.SubDepartments.Add(lReports);
            logistics.Employee.Add(new Person("Herminia Larson", "Female"));
            logistics.Employee.Add(new Person("Marci Collins", "Female"));
            logistics.Employee.Add(new Person("Earl Forbes", "Male"));
            logistics.Employee.Add(new Person("Dion Benson", "Male"));

            Department customer = new Department("Customer Service", "Perry Francis");
            Department requests = new Department("Requests", "Reed Solis");
            Department complaints = new Department("Complaints", "Suzette Charles");
            Department serving = new Department("Serving", "Latisha Travis");
            Department cReports = new Department("Customer Report", "Erika Reese");
            root.Departments.Add(customer);
            customer.SubDepartments.Add(requests);
            customer.SubDepartments.Add(complaints);
            customer.SubDepartments.Add(serving);
            customer.SubDepartments.Add(cReports);
            customer.Employee.Add(new Person("Mavis Marks", "Female"));
            customer.Employee.Add(new Person("Lester Hendricks", "Male"));
            customer.Employee.Add(new Person("Marty Richards", "Male"));
            customer.Employee.Add(new Person("Roberta Keller", "Female"));

            Department advertisment = new Department("Advertisment", "Tami Ayala");
            Department creation = new Department("Creation", "Rene Miles");
            Department cost = new Department("Cost", "Brendan Walter");
            Department efficiency = new Department("Efficiency", "Tommy Patton");
            Department aReports = new Department("Advertisment Report", "Milan Combs");
            root.Departments.Add(advertisment);
            advertisment.SubDepartments.Add(creation);
            advertisment.SubDepartments.Add(cost);
            advertisment.SubDepartments.Add(efficiency);
            advertisment.SubDepartments.Add(aReports);
            advertisment.Employee.Add(new Person("Lynn Singh", "Male"));
            advertisment.Employee.Add(new Person("Antione Walter", "Male"));
            advertisment.Employee.Add(new Person("Titus Daniel", "Male"));
            advertisment.Employee.Add(new Person("Lila Glass", "Female"));

            Department manufacturing = new Department("Manufacturing", "Audra Manning");
            Department production = new Department("Production", "Williams Patterson");
            Department research = new Department("Research", "Lynette Robertson");
            Department mMarketing = new Department("Marketing", "Silas Steele");
            Department mReports = new Department("Manufacturing Report", "Marcelo Clements");
            root.Departments.Add(manufacturing);
            manufacturing.SubDepartments.Add(production);
            manufacturing.SubDepartments.Add(research);
            manufacturing.SubDepartments.Add(mMarketing);
            manufacturing.SubDepartments.Add(mReports);
            manufacturing.Employee.Add(new Person("Pablo Trevino", "Male"));
            manufacturing.Employee.Add(new Person("Moses Nguyen", "Male"));
            manufacturing.Employee.Add(new Person("Tonya Nunez", "Female"));
            manufacturing.Employee.Add(new Person("Pat Chaney", "Female"));

            Department administration = new Department("Administration", "Katy Hooper");
            Department manage = new Department("Manage", "Louisa Holland");
            Department statistics = new Department("Statistics", "Darryl Vincent");
            Department creating = new Department("Creating", "Wes Harvey");
            Department administrationReports = new Department("Administration Report", "Allen Barnett");
            root.Departments.Add(administration);
            administration.SubDepartments.Add(manage);
            administration.SubDepartments.Add(statistics);
            administration.SubDepartments.Add(creating);
            administration.SubDepartments.Add(administrationReports);
            administration.Employee.Add(new Person("Elmo Morris", "Male"));
            administration.Employee.Add(new Person("Alberta Mosley", "Female"));
            administration.Employee.Add(new Person("Shari Collier", "Female"));
            administration.Employee.Add(new Person("Debbie Pitts", "Female"));

            Department purchasing = new Department("Purchasing", "Allyson Vance");
            Department equipment = new Department("Equipment", "Loyd Werner");
            Department place = new Department("Place", "Theron Meadows");
            Department product = new Department("Product", "Faustino Lin");
            Department pReport = new Department("Purchasing Report", "Kareem Hicks");
            root.Departments.Add(purchasing);
            purchasing.SubDepartments.Add(equipment);
            purchasing.SubDepartments.Add(place);
            purchasing.SubDepartments.Add(product);
            purchasing.SubDepartments.Add(pReport);
            purchasing.Employee.Add(new Person("Lenard Guerra", "Male"));
            purchasing.Employee.Add(new Person("Reyes Cruz", "Male"));
            purchasing.Employee.Add(new Person("Zack Lindsey", "Male"));
            purchasing.Employee.Add(new Person("Jodie Baird", "Female"));

            Department riskManagement = new Department("Risk Management", "Noelle Suarez");
            Department riskStatistics = new Department("Risk Statistics", "Marian Webb");
            Department riskPlanning = new Department("Risk Planning", "Lorenzo Spears");
            Department riskSpot = new Department("Risk Spot", "Lesley Walton");
            Department rReport = new Department("Risk Report", "Audrey Johns");
            root.Departments.Add(riskManagement);
            riskManagement.SubDepartments.Add(riskStatistics);
            riskManagement.SubDepartments.Add(riskPlanning);
            riskManagement.SubDepartments.Add(riskSpot);
            riskManagement.SubDepartments.Add(rReport);
            riskManagement.Employee.Add(new Person("Lila Bryan", "Female"));
            riskManagement.Employee.Add(new Person("Chandra Boyd", "Female"));
            riskManagement.Employee.Add(new Person("Clair Clements", "Male"));
            riskManagement.Employee.Add(new Person("Cole Tanner", "Male"));

            Department projectPlanning = new Department("Project Planning", "Kenton Park");
            Department documenantation = new Department("Documentation", "Brad Curry");
            Department projectCreation = new Department("Project Creation", "Leticia Schmitt");
            Department projectCost = new Department("Project Cost", "Sammy Booth");
            Department projectReport = new Department("Project Report", "Louella Crawford");
            root.Departments.Add(projectPlanning);
            projectPlanning.SubDepartments.Add(documenantation);
            projectPlanning.SubDepartments.Add(projectCreation);
            projectPlanning.SubDepartments.Add(projectCost);
            projectPlanning.SubDepartments.Add(projectReport);
            projectPlanning.Employee.Add(new Person("Victoria Holt", "Female"));
            projectPlanning.Employee.Add(new Person("Kellie Gonzales", "Female"));
            projectPlanning.Employee.Add(new Person("Jean Bates", "Female"));
            projectPlanning.Employee.Add(new Person("Ian Stokes", "Male"));

            Department communication = new Department("Communication", "Norris Harvey");
            Department pressCommunication = new Department("Press Communication", "Mike Brooks");
            Department massMedia = new Department("Mass Media", "Lou Montgomery");
            Department companyCommunication = new Department("Company Communication", "Howard Collier");
            Department communicationReports = new Department("Communication Report", "Clemente Pena");
            root.Departments.Add(communication);
            communication.SubDepartments.Add(pressCommunication);
            communication.SubDepartments.Add(massMedia);
            communication.SubDepartments.Add(companyCommunication);
            communication.SubDepartments.Add(communicationReports);
            communication.Employee.Add(new Person("Roscoe Brewer", "Male"));
            communication.Employee.Add(new Person("Darla Herring", "Female"));
            communication.Employee.Add(new Person("Aileen Conrad", "Female"));
            communication.Employee.Add(new Person("Bethany George", "Female"));

            return root;
        }
    }
}
