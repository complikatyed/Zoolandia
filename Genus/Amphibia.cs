using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Amphibia : Animal
    {

        public override string GenusName
        { 
            get
            {
                return "amphibian";
            }
            set
            {
                this.GenusName = "amphibian";
            }
        }

        public override string Diet
        {
            get
            {
                return "omnivorous";
            }
            set
            {
                this.Diet = "omnivorous";
            }
        }

        public string SpeciesName{ get; set;}
        public override bool Swim( bool swim)
        {
            return swim;
        }

        public override void Breathe()
        {

        }

        public override bool Sound( bool sound)
        {
            return sound;
        }
        public override void Reproduce(){
            // are all amphibians tadpole types? 
        }


    }
}