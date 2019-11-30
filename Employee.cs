using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Employee : Person 
    {
        protected string Department;
        protected uint Salary;
        private static List<string> Dep = new List<string>(){ "Production", "Accounting", "Sales", "Marketing" };

        public Employee(string first, string last, string id, string department, uint salary) : base(first, last, id)
        {
            if (Dep.Contains(department))
                this.Department = department;
            else throw new ArgumentException("There are no such department");
            this.Salary = salary;
        }

        public override string ToString() => base.ToString() + $"  Department: {this.Department}  Salary: {this.Salary}";
    }
}
