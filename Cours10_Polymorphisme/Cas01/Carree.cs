using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class Carree:Forme
    {
        double cote; 
        public Carree(double cote)
        {
            this.cote = cote;

        }

        public override double CalculerPerimetre()
        {
            return cote * 4;
        }
    }
}
