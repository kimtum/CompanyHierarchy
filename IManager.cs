using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IManager
    {
        HashSet<RegularEmployee> UnderCommand { get; }
        bool Add(RegularEmployee emp);
        int Count { get; }
        bool Remove(RegularEmployee emp);
        void Clear();
        bool Contains(RegularEmployee emp);
        IEnumerator<RegularEmployee> GetEnumerator();
    }
}
