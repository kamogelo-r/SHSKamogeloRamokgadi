using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    public abstract class Person
    {
        private string name;
        private string surname;
        private string dOB;
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public string DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }        
        
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(){}

        public Person(string name, string surname, string dOB, string address)
        {
            this.name = name;
            this.surname = surname;
            this.dOB = dOB;
            this.address = address;
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
