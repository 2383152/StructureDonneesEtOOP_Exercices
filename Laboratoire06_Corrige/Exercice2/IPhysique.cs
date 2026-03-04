using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal interface IPhysique
    {
        double EnergieCinetique(double masse, double vitesse);
        double ForceGravitationnelle(double masse, double masse2, double distance);
    }
}
