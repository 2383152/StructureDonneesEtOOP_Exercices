using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Rectangle:Forme
    {
        double largeur;
        double hauteur;


        //Constructeur

        public Rectangle(double largeur, double hauteur)
        {
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        //Redéfinition de la méthode pour calculer l'air
        public override double CalculerAire()
        {
            return largeur * hauteur;
        }
    }
}
