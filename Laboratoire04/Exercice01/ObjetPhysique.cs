using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class ObjetPhysique
    {
        public double Masse { get; set;}
        public double Volume { get; set;}

        public ObjetPhysique(double masse, double volume)
        {
            Masse = masse;
            Volume = volume;
        }

        public void CalculerDensité()
        {
            double densite = Masse / Volume;

            Console.WriteLine("Densité: " + densite);
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Masse: " + Masse);
            Console.WriteLine("Volume: " + Volume);
            CalculerDensité();
        }


    }
}
