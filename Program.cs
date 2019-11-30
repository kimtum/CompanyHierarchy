using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Aaron", "Ramsey", "a67458", "Sales", 900);
            Employee emp1 = new Employee("George", "Green", "k65477", "Marketing", 1100);
            Manager manager = new Manager("John", "Doe", "p74879", "Production", 2000);
            manager.Add(emp);
            manager.Add(emp1);
            SalesEmployee semp = new SalesEmployee("Gary", "Neville", "a67464", "Marketing", 1000);
            semp.Add("VR", DateTime.Now, 500);
            Developer developer = new Developer("Jane", "Doe", "t65989", "Accounting", 1800);
            developer.Add("FaceID", DateTime.Now, "some details", state.Open);
            List<Employee> employees = new List<Employee>() { manager, semp, developer };
            foreach(var employee in employees)
            {
                Console.WriteLine(employee + "\n");
            }
            Console.ReadLine();
        }
    }
}
