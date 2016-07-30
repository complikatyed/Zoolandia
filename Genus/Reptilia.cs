//snakes, lizards, crocodiles, turtles, and tortoises
using System;
using  Zoolandia;

namespace Zoolandia.Genus
{
    public class Reptilia: Animal
    {

        public Reptilia() : base() 
        {}
        public string ClassName
        { 
            get 
            {
                return "reptile";
            }
            set
            {
                this.ClassName = "reptile";
            }
        }
        //public string SpeciesName { get; set; }
        public string Diet { get; set; }

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