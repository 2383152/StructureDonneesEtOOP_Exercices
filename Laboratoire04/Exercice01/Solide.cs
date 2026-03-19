using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Solide: ObjetPhysique
    {
        public string Forme { get; set; }

        public Solide(double masse, double volume, string forme):base (masse, volume)
        {
            Forme = forme;
        }

        public void AfficherInfoSolide()
        {
            Console.WriteLine("Forme: " + Forme);

            //Puisque la classe solide hérite de toutes les méthodes de la classe objet physique, tu peux aussi faire ca:
            AfficherInfo();
        }
    }
}
