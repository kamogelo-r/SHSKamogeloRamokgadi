using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class ProductManagement:Department
    {
        private string configuration;
        private string option;
        private string productName;
        private string componentName;

        public string ComponentName
        {
            get { return componentName; }
            set { componentName = value; }
        }
        
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        
        public string Option
        {
            get { return option; }
            set { option = value; }
        }
        
        public string Configuration
        {
            get { return configuration; }
            set { configuration = value; }
        }        

        public ProductManagement(){}

        public ProductManagement(string departmentName, string manager, string configuration, string option, string productName, string componentName):base(departmentName, manager)
        {
            this.option = option;
            this.configuration = configuration;
            this.componentName = componentName;
            this.productName = productName;
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
