//snakes, lizards, crocodiles, turtles, and tortoises
using System;

namespace Zoolandia.Genus
{
    public class Reptilia: Genus
    {

        public override string GenusName
        { 
            get 
            {
                return "reptile";
            }
        }

        public override string Diet
        {
            get
            {
                return "carnivorous";
            }
        }
        // add exothermic
        // add lay eggs  (use overload of Animal.Reproduction())
        public void Reproduce(string how){
            if ( how == "eggs") {
                Console.WriteLine("They reproduce by laying eggs");
            }
            else
            {
                Console.WriteLine("They give birth to live babies");
            }

        }

        interface ISlither
        {
            void wriggle();
            void writhe();
        }

    }
}