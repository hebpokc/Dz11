using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        string developerName;
        DateTime developTime;
        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public DateTime DevelopTime
        {
            get
            {
                return developTime;
            }
        }
        public DeveloperInfoAttribute(string name)
        {
            developerName = name;
            developTime = DateTime.Now;
        }
    }
}
