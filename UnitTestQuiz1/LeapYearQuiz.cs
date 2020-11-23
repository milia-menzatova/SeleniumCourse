using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestQuiz1
{
    [TestClass]
    public class LeapYearQuiz
    {
        [TestMethod]
        public void Leap_Year_2018()
        {
            // call the IsLeapYear method to test;
            string result = IsLeapYear(2018);
            Assert.AreEqual(result, "No");
        }

       
        [TestMethod]
        public void Leap_Year_2020() 
        {
            string result = IsLeapYear(2020);
            Assert.AreEqual(result, "Yes");
        }
        public string IsLeapYear(int givenYear) 
        {
            //vars
            int nYear;
            int nFhun;
            int nHun;
            int nFour;
            int nEven;
            string sFhun;
            string sHun;
            string sFour;
           

          
            // what year are we testing?
            nYear = givenYear;
            nFhun = nYear % 400;
            if (nFhun == 0)
            {
                sFhun = "Divisible by 400: Yes";
            }
            else 
            {
                sFhun = "Divisible by 400: No";
            }
            
            nHun = nYear % 100;
            if (nHun == 0)
            {
                sHun = "Divisible by 100: Yes";
            }
            else 
            {
                sHun = "Divisible by 100: No";
            }
            
            nFour = nYear % 4;
            if (nFour == 0)
            {
                sFour = "Divisible by 4: Yes";
            }
            else 
            {
                sFour = "Divisible by 4: No";
            }
            
            nEven = nYear % 2;
            //display all operations
            Console.WriteLine("Year: " + nYear);
            Console.WriteLine(sFour);
            Console.WriteLine(sHun);
            Console.WriteLine(sFhun);
            //determine if leap year
            if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            else if (nEven == 1)
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            else 
            {
                return "No";
            }
        }
    }
}
