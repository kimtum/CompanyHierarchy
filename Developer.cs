using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {

        public Developer(string first, string last, string id, string department, uint salary)
            : base(first, last, id, department, salary)
        {
            this.Projects = new HashSet<Dictionary<string, object>>();
        }

        public HashSet<Dictionary<string, object>> Projects { get; private set; }

        public int Count => Projects.Count;

        public bool Add(string project, DateTime projstartdate, string details, state state)
        {
            Dictionary<string, object> projects = new Dictionary<string, object>(4);
            projects.Add("Project name", project);
            projects.Add("Project start date", projstartdate);
            projects.Add("Details", details);
            projects.Add("State", state);

            return this.Projects.Add(projects);
        }

        public void Clear()
        {
           this.Projects.Clear();
        }

        public bool Contains(Dictionary<string, object> project)
        {
            return this.Projects.Contains(project);
        }

        public IEnumerator<Dictionary<string, object>> GetEnumerator()
        {
            return this.Projects.GetEnumerator();
        }

        public bool Remove(Dictionary<string, object> project)
        {
            return this.Projects.Remove(project);
        }

        public override string ToString()
        {
            string projects = "";
            
            { 
                foreach(var proj in this.Projects)
                {
                    projects += "\n";
                    foreach(var ch in proj)
                    {
                        projects += ch.Key + ": " + ch.Value.ToString() + ", ";
                    }
                    
                }
                return base.ToString() + projects;
            }
        }

    }
}
