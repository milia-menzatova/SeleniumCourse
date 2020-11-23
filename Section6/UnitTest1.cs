using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Car_Class_Color_Set()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            // act

            // assert
            Assert.AreEqual(myCar.Color, "Red");
        }
        [TestMethod]
        public void Call_Accelerate_Method() 
        {
            //arrange
            Car myCar = new Car("Red", 2, true);
            // act
            myCar.Accelerate();
           
        }
        [TestMethod]
        public void Call_FamilyCar_Method() 
        {
            //arrange
            Car myCar = new Car("Red", 4, true);
            // act
            bool typeCar = myCar.FamilyCar();
            // assert
            if (typeCar == true)
            {
                Assert.IsTrue(typeCar == true);
            }
            else 
            {
                Assert.Fail();
            }
        }



    }
}
