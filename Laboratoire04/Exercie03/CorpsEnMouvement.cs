using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie03
{
    internal class CorpsEnMouvement
    {
        public double PositionX {  get; set; }
        public double PositionY { get; set; }
        public double Vitesse { get; set; }

        public CorpsEnMouvement(double positionX, double positionY, double vitesse)
        {
            PositionX = positionX;
            PositionY = positionY;
            Vitesse = vitesse;
        }

        public void AfficherEtat()
        {
            Console.WriteLine("Position en X: " + PositionX);
            Console.WriteLine("Position en Y: " + PositionY);
            Console.WriteLine("Vitesse: " + Vitesse);
        }
    }
}
