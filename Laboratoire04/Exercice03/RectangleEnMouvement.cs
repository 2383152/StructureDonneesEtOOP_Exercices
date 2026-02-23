using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class RectangleEnMouvement:CorpsEnMouvement
    {
        double Largeur;
        double Hauteur;

        public RectangleEnMouvement(double largeur, double hauteur, double positionX, double positionY, double vitesse):base(positionX, positionY, vitesse)
        {
            Largeur = largeur;
            Hauteur = hauteur;  
        }

        public new void AfficherEtat()
        {
            base.AfficherEtat();
            Console.WriteLine($"Dimension: {Largeur}m x {Hauteur}m");
        }
    }
}
