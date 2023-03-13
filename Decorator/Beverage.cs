using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator
{
    public abstract class Beverage
    {
        private string description;
        public string Description {
            get { return description; }
            set { if (string.IsNullOrEmpty(value))
                    description = "Unknown Beverage";
                else description = value; 
            }
        }
        public abstract double Cost();

        public abstract string GetDescription();
    }
}
