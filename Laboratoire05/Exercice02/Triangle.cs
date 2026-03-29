using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Triangle : Forme
    {
        double _base;
        double hauteur;
        string nom;

        public Triangle(double _base, double hauteur, string nom)
        {
            this._base = _base;
            this.hauteur = hauteur;
            this.nom = nom;
        }

        public override double CalculerAire()
        {
            return (_base * hauteur) / 2;
        }
    }
}
