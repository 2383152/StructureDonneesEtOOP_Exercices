using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class Pays
    {
        public string Nom {  get; set; }
        public Ville Capital { get; set; }
        public Ville[] TabVille { get; set; }

        public Pays()
        {
            Nom = "Québec";
            Capital = new Ville("Montreal");
            TabVille = new Ville[3] { new Ville("St-Jérôme"), new Ville("Longeuil"), new Ville("Québec") };       
        }

        public Pays(string nomPays, Ville capital)
        {
            Nom = nomPays;
            Capital = capital;
            TabVille = new Ville[3] { new Ville("St-Jérôme"), new Ville("Longeuil"), new Ville("Québec") };
        }

        public Pays(string nomPays, string capital, Ville ville1, Ville ville2, Ville ville3)
        {
            Nom = nomPays;
            TabVille = new Ville[3] { ville1, ville2, ville3 };
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Capital: " + Capital);

            foreach(Ville ville in TabVille)
            {
                Console.WriteLine("Ville:" + ville);
            }
        }

    }
}
