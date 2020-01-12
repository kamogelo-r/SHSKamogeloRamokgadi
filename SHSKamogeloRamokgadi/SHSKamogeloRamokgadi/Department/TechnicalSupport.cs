using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    class TechnicalSupport:Department
    {
        private string servicePerformed;
        private DateTime serviceDate;
                
        public DateTime ServiceDate
        {
            get { return serviceDate; }
            set { serviceDate = value; }
        }        

        public string ServicePerformed
        {
            get { return servicePerformed; }
            set { servicePerformed = value; }
        }        

        public TechnicalSupport(){}

        public TechnicalSupport(string departmentName, string manager, string servicePerformed, DateTime serviceDate):base(departmentName, manager)
        {
            this.servicePerformed = servicePerformed;
            this.serviceDate = serviceDate;
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
