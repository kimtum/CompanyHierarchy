using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CompanyHierarchy
{
    class RegularEmployee : Employee 
    {
        public RegularEmployee(string first, string last, string id, string department, uint salary) 
            : base(first, last, id, department, salary)
        {
        }

        public override string ToString() => base.ToString();

    }
}
