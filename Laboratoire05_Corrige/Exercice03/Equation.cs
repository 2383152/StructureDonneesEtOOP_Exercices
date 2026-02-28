using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal abstract class Equation
    {
        //Méthode abstraite
        public abstract double[] Resoudre();

        //Méthode ToString() pour afficher une représentation de l'équation

        public abstract override string ToString();//override pcq ToString existe déja
    }
}
