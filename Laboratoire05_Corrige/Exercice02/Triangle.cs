using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Triangle:Forme
    {
        double Base; //Seulement propriétés écrit avec premiere lettre majuscule
        double hauteur;


        //Constructeur

        public Triangle(double largeur, double hauteur)
        {
            this.Base = largeur;
            this.hauteur = hauteur;
        }

        //Redéfinition de la méthode pour calculer l'air
        public override double CalculerAire()
        {
            return (Base * hauteur)/2;
        }
    }
}
