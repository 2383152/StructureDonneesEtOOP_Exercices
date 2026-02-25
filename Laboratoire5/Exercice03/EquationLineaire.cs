using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class EquationLineaire:Equation
    {
        double a, b;

        //constructeur
        public EquationLineaire(double a, double b)
        {
            this.a = a; 
            this.b = b;
        }

        //Redéfiniton de la méthode résoudre
        public override double[]Resoudre()
        {
            if (a == 0)
            {
                if (b == 0)
                    return new double[] { double.NaN };//Infinité de solution

                else
                    return new double[] { };//Pas de solution
            }
            else
            {
                return new double[] { -b / a }; //Solution unique
            }
        }

        //Redéfiniton de la méthode ToString()

        public override string ToString()
        {
            return $"{a}x + {b} = 0";
        }
    }
}
