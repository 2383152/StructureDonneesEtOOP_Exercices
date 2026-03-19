using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class CorpsMouvement
    {
        double vitesse, position, temps;

        public CorpsMouvement(double vitesse, double position, double temps)
        {
            this.vitesse = vitesse;
            this.position = position;
            this.temps = temps;
        }

        public double CalculerTempsNouvellePosition(double tempsEntree)
        {
            return position + vitesse * tempsEntree;
        }

        public void AfficherInfoCorpsMouvement()
        {
            Console.WriteLine("Vitesse: " + vitesse);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Temps: " + temps);
        }
    }
}
