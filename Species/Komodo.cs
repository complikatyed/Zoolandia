using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Komodo : Reptilia
    {
        public Komodo(string nickname)
        {
           this.SpeciesName = "Varanus komodoensis";
           this.CommonName = "komodo dragon";
           this.IndividualName = nickname;
           this.Wings = false;
           this.Legs = 4;
        }


    }
}