using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Car
    {
        // private variables that help us define properties of a car (or the class)
        string color;
        int numberOfDoors;
        bool isConvertable;

        // Constractor - factory for creating objects of the class
        public Car(string carColor, int doors, bool convertable)
        {
            color = carColor;
            numberOfDoors = doors;
            isConvertable = convertable;
        }
        // Get and Set Accessors- Properties that define noun-like attributes of the class
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool IsConvertable { get; set; }
        public int NumberOfDoors 
        {
            get { return numberOfDoors; }
            set 
            {
                if (value <= 4)
                {
                    numberOfDoors = value;
                }
                else 
                {
                    // give the user some kind error
                }
            }
        }
        // Methods - verb attributes that tell what a class can do
        public void Accelerate() 
        {
            Console.WriteLine("I am accelerating");
        }
        public bool FamilyCar() 
        {
            if (NumberOfDoors >= 4)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
