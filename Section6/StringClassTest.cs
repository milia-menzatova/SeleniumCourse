using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Test()
        {
            string str = "SQL is a standard language for storing, manipulating and retrieving data in databases";
            Console.WriteLine(str);
            string substring = str.Substring(56);
            Console.WriteLine(substring); // OVERLOADS Substring(Int32)	Retrieves a substring from this instance. 
                                          //The substring starts at a specified character position and continues to the end of the string.
                                          // Substring(Int32, Int32 
                                          //Retrieves a substring from this instance.The substring starts at a specified 
                                          //character position and has a specified length.
        }
        [TestMethod]
        public void Joining_String_Together() 
        {
            char[] chars = {'H', 'e', 'l', 'l', 'o'};
            string name = new string(chars);
            Console.WriteLine(name);
        }
    }
}
