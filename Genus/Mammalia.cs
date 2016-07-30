using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Mammalia : Animal
    {
        
        public Mammalia() : base() 
        {}
        public string ClassName
        { 
            get
            {
                return this.ClassName;
            }
            set
            {
                this.ClassName = "mammal";
            }
        }
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