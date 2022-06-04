using System;
using System.Collections.Generic;
using System.Text;

namespace W3Course4
{
    class Horse:IAnimal // Class can use multiple interfaces. Just separate with comma.
    {
        public void animalNoise()
        {
            Console.WriteLine("Horse goes neigh, neigh"); 
        }
    }
}
