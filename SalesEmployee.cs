using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {

        public SalesEmployee(string first, string last, string id, string department, uint salary)
            : base(first, last, id, department, salary)
        {
            this.Sales = new HashSet<Dictionary<string, object>>();
        }

        public HashSet<Dictionary<string, object>> Sales { get; private set; }

        public int Count => Sales.Count;

        public bool Add(string product, DateTime date, uint price)
        {
            Dictionary<string, object> sales = new Dictionary<string, object>(3);
            sales.Add("Product name", product);
            sales.Add("Data", date);
            sales.Add("Price", price);
            return this.Sales.Add(sales);
        }

        public void Clear()
        {
            this.Sales.Clear();
        }

        public bool Contains(Dictionary<string, object> sale)
        {
            return Sales.Contains(sale);
        }

        public IEnumerator<Dictionary<string, object>> GetEnumerator()
        {
            return Sales.GetEnumerator();
        }

        public bool Remove(Dictionary<string, object> sale)
        {
            return this.Remove(sale);
        }

        public override string ToString()
        {
            string sales = "";

            {
                foreach (var proj in this.Sales)
                {
                    sales += "\n";
                    foreach (var ch in proj)
                    {
                        sales += ch.Key + ": " + ch.Value.ToString() + ", ";
                    }
                    
                }
                return base.ToString() + sales;
            }
        }
    }
}
