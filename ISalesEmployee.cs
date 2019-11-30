using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface ISalesEmployee
    {
        HashSet<Dictionary<string, object>> Sales { get; }
        bool Add(string product, DateTime date, uint price);
        int Count { get; }
        bool Remove(Dictionary<string, object> sale);
        void Clear();
        bool Contains(Dictionary<string, object> sale);
        IEnumerator<Dictionary<string, object>> GetEnumerator();
    }
}
