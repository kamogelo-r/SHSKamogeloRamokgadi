using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi.Product
{
    public abstract class Componentss
    {
        private string componentName;
        private string componentType;

        public string ComponentType
        {
            get { return componentType; }
            set { componentType = value; }
        }
        
        public string ComponentName
        {
            get { return componentName; }
            set { componentName = value; }
        }        

        public Componentss(){}

        public Componentss(string componentName, string componentType)
        {
            this.componentName = componentName;
            this.componentType = componentType;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
