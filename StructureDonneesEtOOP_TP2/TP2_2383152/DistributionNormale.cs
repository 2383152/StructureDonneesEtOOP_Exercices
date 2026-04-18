using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2383152
{
    internal class DistributionNormale : Distribution
    {
        private int TailleEchantillon {  get; set; }
        private double MoyenneTheorique { get; set; }
        private double EcartType { get; set; }

        private static Random random = new Random();

        public DistributionNormale(int tailleEchantillon, double moyenneTheorique, double ecartType)
        {
            TailleEchantillon = tailleEchantillon;
            MoyenneTheorique = moyenneTheorique;
            EcartType = ecartType;
        }

        public override void CalculerDistribution()
        {
            //Formule Box-Muller
            echantillon = new List<double>();

            for (int i = 0; i < TailleEchantillon; i++)
            {
                double u1 = random.NextDouble();
                double u2 = random.NextDouble();

                double z = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);

                double valeur = MoyenneTheorique + EcartType * z;
                echantillon.Add(valeur);
            }
        }

        public override double CalculerMoyenneTheorique()
        {
            return MoyenneTheorique;
        }

        public override double CalculerVarianceTheorique()
        {
            double varianceTheorique = EcartType * EcartType;

            return varianceTheorique;
        }
    }
}
