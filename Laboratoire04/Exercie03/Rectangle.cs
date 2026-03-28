using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie03
{
    internal class Rectangle : CorpsEnMouvement
    {
        public double Largeur {  get; set; }
        public double Hauteur { get; set; }

        public Rectangle(double largeur, double hauteur, double positionX, double positionY, double vitesse) : base(positionX, positionY, vitesse)
        {
            Largeur = largeur;
            Hauteur = hauteur;
        }

        public void AfficherEtat()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Largeur:  " + Largeur);
            Console.WriteLine("Hauteur:  " + Hauteur);
            base.AfficherEtat();
        }
    }
}
