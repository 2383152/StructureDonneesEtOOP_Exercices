using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class Cercle:Forme
    {
        double rayon;
        public Cercle(double rayon)
        {
            this.rayon = rayon;

        }

        public override double CalculerPerimetre()
        {
            return rayon * 2 * Math.PI;
        }
    }
}
