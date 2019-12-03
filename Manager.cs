using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee, IManager
    {

        public Manager(string first, string last, string id, string department, uint salary)
            : base(first, last, id, department, salary)
        {
            this.UnderCommand = new HashSet<RegularEmployee>();
        }

        public HashSet<RegularEmployee> UnderCommand{ get; private set; }
        

        public bool Add(RegularEmployee emp)
        {
            return this.UnderCommand.Add(emp);
        }


        public void Clear() 
        {
            this.UnderCommand.Clear();
        }

        public bool Contains(RegularEmployee emp) 
        { 
            return this.UnderCommand.Contains(emp); 
        }
       

        public int Count => this.UnderCommand.Count;
                

        public IEnumerator<RegularEmployee> GetEnumerator()
        {
            return this.UnderCommand.GetEnumerator();
        }

        public bool Remove(RegularEmployee emp)
        {
            return this.UnderCommand.Remove(emp);
        }

        public override string ToString()
        {
            string employees = "";
            foreach(var emp in this.UnderCommand)
            {
                employees += emp.ToString() + ", ";
            }
            return base.ToString() + "\nEmployees under command: " + employees;
        }
    }
}
