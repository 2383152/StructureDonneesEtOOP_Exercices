using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal interface IGestionTableaux
    {
        void AfficherTableau(double[,] tableau);
        List<double> ConvertiTableauEnListe(double[,] tableau);
    }
}
