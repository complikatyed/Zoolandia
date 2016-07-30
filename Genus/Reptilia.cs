//snakes, lizards, crocodiles, turtles, and tortoises
using System;
using  Zoolandia;

namespace Zoolandia.Genus
{
    public class Reptilia: Animal
    {

        //public Reptilia() : base() 
        //{}
        public override string GenusName
        { 
            get 
            {
                return "reptile";
            }
        }
        public string SpeciesName { get; set; }

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

    }
}