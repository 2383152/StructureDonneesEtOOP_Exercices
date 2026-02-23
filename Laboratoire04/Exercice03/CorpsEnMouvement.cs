using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class CorpsEnMouvement
    {
        double PositionX {  get; set; }
        double PositionY {  get; set; }
        double Vitesse {  get; set; }

        //Constructeur
        public CorpsEnMouvement(double positionX, double positionY, double vitesse)
        {
            PositionX = positionX;
            PositionY = positionY;
            Vitesse = vitesse;
        }

        //Méthode pour afficher l'état
        public void AfficherEtat()
        {
            Console.WriteLine($"Position en X: {PositionX}, Position en Y: {PositionY}, Vitesse: {Vitesse}");
        }
    }
}
