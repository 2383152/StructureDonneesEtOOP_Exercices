using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class Ville
    {
        public string Nom {  get; set; }
        public CoordGeo Coord {  get; set; }
        public int Population { get; set; }

        public Ville(string nomVille)
        {
            Coord = new CoordGeo(nomVille); //ok ca c'est actually vrm cool            
        }

        public Ville(string nom, double Longitude, double Latitude, int population)
        {
            this.Nom = nom;
            //this.Coord.Longitude = Longitude;
            //this.Coord.Latitude = Latitude;
            this.Population = population;
        }

        public Ville(string nom, CoordGeo coord, int population)
        {
            this.Nom = nom;
            this.Coord = coord;
            this.Population = population;
        }

        public void AfficherInformation()
        {
            Console.WriteLine("Nom: " + Nom);
            Coord.AfficherCoord();
            Console.WriteLine("Population: " + Population);

        }
    }
}
