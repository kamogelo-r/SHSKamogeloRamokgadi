using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    public abstract class Product
    {
        private string productName;
        private string description;
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }        

        public Product(){}

        public Product(string productName, string description, double price)
        {
            this.productName = productName;
            this.description = description;
            this.price = price;
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
