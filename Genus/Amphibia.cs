using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Amphibia : Animal
    {

        public Amphibia() : base() 
        {}
        public string ClassName
        { 
            get
            {
                return this.ClassName;
            }
            set
            {
                this.ClassName = "amphibian";
            }
        }
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