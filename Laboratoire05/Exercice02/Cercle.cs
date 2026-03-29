using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Cercle : Forme
    {
        double rayon;
        string nom;

        public Cercle(double rayon, string nom)
        {
            this.rayon = rayon;
            this.nom = nom;
        }

        public override double CalculerAire()
        {
            return Math.PI * (rayon * rayon);
        }
    }
}
