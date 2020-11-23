using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizEmployee
{
    public class Employee
    {  // private variables that help us define properties.
        private string employeeNumber;
        private string employeeFirstName;
        private string employeeLastName;
        private string dateOfHire;
        private string jobDescription;
        private string department;
        private decimal salary;

        //Constractor
        public Employee(string empNumber, string empFirstName, string empLastName, string hiredate, string job, string dep, decimal empsalary)
        {
            employeeNumber = empNumber;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hiredate;
            jobDescription = job;
            department = dep;
            salary = empsalary;
        }

        public Employee(string empFirstName, string empLastName)
        {
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
        }
        // Get and Set Accessors- Properties that define noun-like attributes of the class
        public string empNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public string empFirstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }
        public string empLastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }
        public string hiredate
            {
            get { return dateOfHire; }
            set { dateOfHire = value; }
            }
        public string job 
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
        public string dep 
        {
            get { return department; }
            set { department = value; }
        }
        public decimal empsalary 
        {
            get { return salary; }
            set { salary = value; }
        }
        //methods
        public string ReturnFullName() 
        { 
            return employeeFirstName + " " +  employeeLastName;
        }
        public string ReturnFullNameForSortingPurposes() 
        {
            return employeeFirstName + " , " + employeeLastName;
        }













    }
}
