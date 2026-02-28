using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class ObjetPhysique
    {
        string nomObjet;
        double masse;
        double volume;
        double densite;

        public ObjetPhysique(double masse, double volume, double densite, string nomObjet)
        {
            this.masse = masse;
            this.volume = volume;
            this.densite = densite;
            this.nomObjet = nomObjet;
        }

        public double CalculerDensite()
        {
            densite = masse / volume;
            return densite;
        }

        public void AfficherInfoObjetPhysique()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Objet physique: {nomObjet}");
            Console.WriteLine($"Masse: {masse}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Densité: {densite}");
            Console.WriteLine("--------------------------------------------");
        }


    }
}
