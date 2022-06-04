using System;
using System.Collections.Generic;
using System.Text;

namespace W3Course4
{
    abstract class Animal
    {
        string skin; // field
        public abstract void animalSound(); //abstrct method (no body)

        public void sleep() // regular method
        {
            Console.WriteLine("zzz");
        }
    }
}
