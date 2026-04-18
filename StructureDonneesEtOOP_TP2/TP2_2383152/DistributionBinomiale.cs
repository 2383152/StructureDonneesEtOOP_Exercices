using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2383152
{
    internal class DistributionBinomiale : Distribution
    {
        private int TailleEchantillon { get; set; }
        private int NbTotalEssaie { get; set; }
        private double ProbabiliteSucces { get; set; }

        private static Random random = new Random();

        public DistributionBinomiale(int tailleEchantillon, int nbTotalEssais, double probabiliteSucces)
        {
            TailleEchantillon = tailleEchantillon;
            this.NbTotalEssaie = nbTotalEssais;
            this.ProbabiliteSucces = probabiliteSucces;
        }
        public override void CalculerDistribution()
        {
            echantillon = new List<double>();

            for (int i = 0; i < TailleEchantillon; i++)
            {
                int succes = 0;

                for (int j = 0; j < NbTotalEssaie; j++)
                {
                    double u = random.NextDouble();
                    if (u < ProbabiliteSucces)
                        succes++;
                }

                echantillon.Add(succes);
            }
        }

        public override double CalculerMoyenneTheorique()
        {
            double moyenne = TailleEchantillon * ProbabiliteSucces;

            return moyenne;
        }

        public override double CalculerVarianceTheorique()
        {
            double variance = TailleEchantillon * ProbabiliteSucces * (1 - ProbabiliteSucces);

            return variance;
        }
    }
}
