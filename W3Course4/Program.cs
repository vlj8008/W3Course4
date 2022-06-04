using System;

namespace W3Course4
{
    class Program
    {

        public enum Volume //used for group of constants.
        {
            low, //value = 0
            medium = 6, // value = 6
            high // value = 7
        }

        static void Main(string[] args)
        {
            Pig pig1 = new Pig();// must use Pig datatype bc can't make object from abstract animal class
            pig1.animalSound();//accessing abstract method from abstact animal class (implementation
            // in pig class)
            pig1.sleep(); //accessing regular method from abstract animal class.

            Horse horse = new Horse();
            horse.animalNoise();

            // Accessing Enum 

            Volume myVar = Volume.high;
            Console.WriteLine(myVar);

            //Finding the value of Enum (must explicitly convert to int)

            int numOfLow = (int)Volume.low;
            Console.WriteLine(numOfLow);

            int valueOfHigh = (int)Volume.high;
            Console.WriteLine(valueOfHigh);

            // Using Enum in switch statement

            switch (myVar)
            {
                case Volume.low:
                    Console.WriteLine("volume low");
                    break;

                case Volume.medium:
                    Console.WriteLine("Volume medium");
                    break;

                case Volume.high:
                    Console.WriteLine("Volume high");
                    break;
            }




            
            
           

        }
    }
}
