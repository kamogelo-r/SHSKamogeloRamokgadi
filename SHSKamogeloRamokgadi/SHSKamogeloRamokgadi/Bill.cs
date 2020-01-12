using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class Bill
    {
        private double amount;
        private DateTime dateBilled;
        private string purpose;

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        
        public DateTime DateBilled
        {
            get { return dateBilled; }
            set { dateBilled = value; }
        }
        
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }        

        public Bill(){}

        public Bill(double amount, DateTime dateBilled, string purpose)
        {
            this.amount = amount;
            this.dateBilled = dateBilled;
            this.purpose = purpose;
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
