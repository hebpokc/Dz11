using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab14
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperInfo2Attribute : Attribute
    {
        string developerName;
        string developOrganization;
        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public string DevelopOrganization
        {
            get
            {
                return developOrganization;
            }
        }
        public DeveloperInfo2Attribute(string name, string organisation)
        {
            developerName = name;
            developOrganization = organisation;
        }
    }
}
