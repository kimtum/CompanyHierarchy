using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IDeveloper
    {
        HashSet<Dictionary<string, object>> Projects { get; }
        bool Add(string project, DateTime projstartdate, string details, state state);
        int Count { get; }
        bool Remove(Dictionary<string, object> project);
        void Clear();
        bool Contains(Dictionary<string, object> project);
        IEnumerator<Dictionary<string, object>> GetEnumerator();
        
    }
    enum state : byte
        {
            Closed,
            Open,
        }
}
