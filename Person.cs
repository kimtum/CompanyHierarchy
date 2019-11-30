using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Person 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ID { get; private set; }

        public Person(string first, string last, string id)
        {
            this.FirstName = first;
            this.LastName = last;
            this.ID = id;
        }

        public override string ToString() => $"First Name: {this.FirstName}  Last Name: {this.LastName}  ID: {this.ID}";
            
    }
}
