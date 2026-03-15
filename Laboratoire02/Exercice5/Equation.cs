using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal class Equation
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void AfficherEquationQuadratique()
        {
            Console.WriteLine($"L'équation quadratique est: {a}x^2 + {b}x + {c}");
        }

        public double CalculerDiscriminant()
        {
            double discriminant = (b * b) - (4 * a * c);
            Console.WriteLine("Le discriminant est: " + discriminant);

            return discriminant;
        }

        public void CalculerRacine()
        {
            double discriminant = CalculerDiscriminant();

            
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Les solutions sont: x1 = {x1} et x2 = {x2}");
            }
            else if(discriminant == 0)
            {
                double x = -b / 2;
                Console.WriteLine($"La solution est: x = {x}");
            }
            else
            {
                Console.WriteLine($"La solution n'existe pas.");
            }
        }
    }
}
