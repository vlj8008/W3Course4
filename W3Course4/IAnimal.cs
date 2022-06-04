using System;
using System.Collections.Generic;
using System.Text;

namespace W3Course4
{
    interface IAnimal
    {
        //public string Genus; Interface can NOT contain fields
        //can contain properties.
        

        public void animalNoise(); // Interface can contain empty methods.
        
    }
}
