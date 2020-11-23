using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class EmpTest
    {
        [TestMethod]
        public void Test_Employee_ID_Set()
        {
            EmployeeClass employee = new EmployeeClass(123);
            employee.JobTitle = "Manager";
            string jobLocation = employee.JobLocation();
            Assert.AreEqual(jobLocation, "Boston");

        }
    }
}
