using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class CercleEnMouvement:CorpsEnMouvement
    {
        double Rayon; 

        //Constructeur
        public CercleEnMouvement(double Rayon, double positionX, double positionY, double vitesse):base(positionX, positionY, vitesse)
        {
            this.Rayon = Rayon;
        }

        //Permet de cacher la méthode de la classe mère
        public void AfficherEtat()
        {
            base.AfficherEtat();
            Console.WriteLine($"Rayon: {Rayon}");
        }
    }
}
