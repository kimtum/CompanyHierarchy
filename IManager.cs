using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IManager
    {
        HashSet<Employee> UnderCommand { get; }
        bool Add(Employee emp);
        int Count { get; }
        bool Remove(Employee emp);
        void Clear();
        bool Contains(Employee emp);
        IEnumerator<Employee> GetEnumerator();
    }
}
