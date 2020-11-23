using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuizEmployee
{
    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void ReturnFullName()
        {
            Employee myEmployee = new Employee("Milia", "Anifeeva");
            string fullname = myEmployee.ReturnFullName();
            Assert.AreEqual(fullname, "Milia Anifeeva");
        }
        [TestMethod]
        public void ReturnFullNameForSortingPurposes() 
        {
            Employee myEmployee = new Employee("Milia", "Anifeeva");
            string fullname = myEmployee.ReturnFullName();
            Assert.AreEqual(fullname, "Milia Anifeeva"); // ???
        }
    }
}
