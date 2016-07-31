
namespace Zoolandia.Genus
{
    public class Amphibia : Genus
    {

        public override string GenusName
        { 
            get
            {
                return "amphibian";
            }
        }

        public override string Diet
        {
            get
            {
                return "omnivorous";
            }
        }

        public override bool Swim(bool swim)
        {
            return swim;
        }

        public override void Breathe()
        {

        }

        public override void Reproduce(){
            // are all amphibians tadpole types? 
        }


    }
}