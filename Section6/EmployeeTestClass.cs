using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class EmployeeClass
    {
        //Constractor
        public EmployeeClass(int id)
        {
            EmployeeID = id;
        }

        public EmployeeClass(string name, int id, string title)
        {
            Name = name;
            EmployeeID = id;
            JobTitle = title;

        }
        //Properties
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string JobTitle { get; set; }
        // methods
        public string JobLocation()
        {
            if (JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";
            }
            return "New York";
        }
    }
}
