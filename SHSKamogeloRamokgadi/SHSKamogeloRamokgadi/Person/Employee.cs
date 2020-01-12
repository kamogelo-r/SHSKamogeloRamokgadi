using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class Employee:Person
    {

        private string employeeNumber;

        public string EmployeeNUmber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }        

        public Employee(){}

        public Employee(string name, string surname, string dOB, string address, string employeeNumber):base(name, surname, dOB, address)
        {
            this.employeeNumber = employeeNumber;
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

        public string AddEmployee(string name)
        {
            return "";
        }

        public string RemoveEmployee(string name)
        {
            return "";
        }                                                                                                                                                                                                                                                                                                                           

    }
}
