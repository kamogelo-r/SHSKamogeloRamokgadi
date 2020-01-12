using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class Client:Person
    {
        private string clientNumber;
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        
        public string ClientNumber
        {
            get { return clientNumber; }
            set { clientNumber = value; }
        }        

        public Client(){}

        public Client(string name, string surname, string dOB, string address, string clientNumber, double amount):base(name, surname, dOB, address)
        {
            this.clientNumber = clientNumber;
            this.amount = amount;
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
