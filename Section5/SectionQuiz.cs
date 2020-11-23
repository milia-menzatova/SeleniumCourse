using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            // given the tem in fahrenheit use a math
            // expression to convert the temp to celcius
            // display output string to the console that says
            // The temp in F {given temp} is {temp} in C
            // replacing the values as necessary in the string
            double tempInF = 47;
            // (32°F − 32) × 5 / 9 = 0°C   (5/9 = .5556)
            double tempInC = (tempInF - 32) * .5556;
            Console.WriteLine($"The temperature in F {tempInF} is {tempInC}");
            Assert.AreEqual(tempInC, 8.334, 0.001);
         }

        [TestMethod]
        public void Convert_C_To_F()
        { //(0°C × 9 / 5) or 1.8 +32 = 32°F
            
            double tempInC = 8;
            double tempInF = (tempInC * 1.8) + 32;
            Console.WriteLine($"The temperature in C {tempInC} is {tempInF} in F");
            Assert.AreEqual(tempInF, 46.4);
        }

    }
}

