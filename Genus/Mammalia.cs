using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Mammalia : Animal
    {
        public override string GenusName
        { 
            get
            {
                return "mammal";
            }
        }

        // public void SetDietType(string diettype)
        // {
        //     this.Diet = diettype;
        // }

        public string SpeciesName { get; set; }
        public override bool Swim( bool swim)
        {
            return swim;
        }
        public override bool Fly( bool fly)
        {
            return fly;
        }

        public override bool Sound( bool sound)
        {
            return sound;
        }
        public override void Reproduce(){
            Console.WriteLine("Mammals give birth to live young.");
        }


    }
}