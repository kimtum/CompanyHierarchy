using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer : Person
    {
        public int Amount { get; private set; }

        public Customer(string first, string last, string id, int amount) : base(first, last, id)
        {
            this.Amount = amount;
        }

        public int Add(int amount) => this.Amount += amount;
        

        public override string ToString() => base.ToString() + $"  Amount: {this.Amount}";
    }
}
