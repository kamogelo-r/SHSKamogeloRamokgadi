using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSKamogeloRamokgadi
{
    public abstract class Department
    {
        private string departmentName;
        private string manager;

        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        public Department(){}

        public Department(string departmentName, string manager)
        {
            this.departmentName = departmentName;
            this.manager = manager;
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
