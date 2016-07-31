using System;

namespace Zoolandia.Genus
{
    public class Mammalia : Genus
    {
        public override string GenusName
        { 
            get
            {
                return "mammal";
            }
        }

        public override bool Swim( bool swim)
        {
            return swim;
        }

        public override void Reproduce(){
            Console.WriteLine("Mammals give birth to live young.");
        }


    }
}