using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class EquationQuadratique:Equation
    {
        double a, b, c;

        public EquationQuadratique(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //redéfintion de la méthode résoudre
        public override double[]Resoudre()
        {
            double discriminant = (b * b) - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[] { }; //pas de solution
            }
            else if (discriminant == 0)
            {
                return new double[] { -b / (2 * a) };//une solution
            }
            else
            {
                double racineDiscriminant = Math.Sqrt(discriminant);

                return new double[]
                {
                    (-b + racineDiscriminant / (2 * a)),
                    (-b - racineDiscriminant / (2 * a)),
                }; //Deux solution
            }
        }

        //redéfinition de la méthode ToString
        public override string ToString()
        {
            return $"{a}x² + {b}x + {c} = 0";
        }

    }
}
