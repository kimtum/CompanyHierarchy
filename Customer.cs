using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer : Person
    {
        private int Amount;

        public Customer(string first, string last, string id, int amount) : base(first, last, id)
        {
            this.Amount = amount;
        }

        public override string ToString() => base.ToString() + $"  Amount: {this.Amount}";
    }
}
