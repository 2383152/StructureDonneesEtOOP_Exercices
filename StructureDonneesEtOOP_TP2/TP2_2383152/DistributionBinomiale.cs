using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2383152
{
    internal class DistributionBinomiale : Distribution
    {
        private int T { get; set; }
        private double n { get; set; }
        private double p { get; set; }

        public DistributionBinomiale(int tailleEchantillion, double nbTotalEssais, double probabiliteSucces)
        {
            T = tailleEchantillion;
            this.n = nbTotalEssais;
            this.p = probabiliteSucces;
        }
        public override void CalculerDistribution()
        {
            Random random = new Random();
            echantillon = new List<double>();

            for (int i = 0; i < T; i++)
            {
                int succes = 0;

                for (int j = 0; j < n; j++)
                {
                    double u = random.NextDouble();
                    if (u < p)
                        succes++;
                }

                echantillon.Add(succes);
            }
        }
    }
}
