using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Cercle:Forme
    {
        double rayon; // examen: définir propriétés, définition attribus, fonction
        public double exempleIDK {  get; private set; }

        //Constructeur

        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        //Redéfinition de la méthode pour calculer l'air
        public override double CalculerAire()
        {
            return Math.PI * rayon * rayon;
        }
    }
}
