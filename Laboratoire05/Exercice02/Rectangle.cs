using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Rectangle : Forme
    {
        double _base;
        double hauteur;
        string nom;

        public Rectangle(double _base, double hauteur, string nom)
        {
            this._base = _base;
            this.hauteur = hauteur;
            this.nom = nom;
        }

        public override double CalculerAire()
        {
            return (_base * hauteur);
        }
    }
}
