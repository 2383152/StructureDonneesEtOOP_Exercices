using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Complex
    {
        double a, b;

        //Constructeur
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        //Accesseurs
        public double GetA() { return a; }
        public double GetB() { return b; }

        //Mutatteurs: pour modifier
        public void SetA(double value) { a = value; }
        public void SetB(double value) { b = value; }

        //Méthode pour afficher les valeurs
        public string AfficherValeur()
        {
            return "(" + a + "," + b + ")";
        }

        //Méthode pour calculer la magnitude
        public double CalculerMagnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        //Surcharge de l'opérateur + 
        public void Sum(Complex nombre)
        {
            a += nombre.GetA();
            b += nombre.GetB();
        }
    }
}
