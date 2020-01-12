using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class ClientManagement: Department
    {
        private string location;
        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        
        public string Location
        {
            get { return location; }
            set { location = value; }
        }        

        public ClientManagement(){}

        public ClientManagement(string departmentName, string manager, string location, string):base(departmentName, manager)
        {
            this.contactNumber = contactNumber;
            this.location = location;
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
