using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Liquide : ObjetPhysique
    {
        public string Couleur { get; set; }

        public Liquide(double masse, double volume, string couleur):base(masse, volume)
        {
            Couleur = couleur;
        }

        public void AfficherInfoLiquide()
        {
            Console.WriteLine("Couleur: " + Couleur);

            //Puisque la classe solide hérite de toutes les méthodes de la classe objet physique, tu peux aussi faire ca:
            AfficherInfo();
        }
    }
}
