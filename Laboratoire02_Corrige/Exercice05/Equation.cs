using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05
{
    internal class Equation
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void CalculerDelta()
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                // Cas 1: Disciminant positif, deux résultat
                double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));

                Console.WriteLine($"Les racines sont réelles et distinctes: x1= {x1}, x2= {x2}");
            }
            else if (delta == 0)
            {
                // Cas 2: Disciminant nul, un résulat
            }
            else
            {
                // Cas 3: Disciminant négatif, pas de solution
            }
        }
}
