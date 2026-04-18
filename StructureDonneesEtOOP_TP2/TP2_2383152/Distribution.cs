using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2383152
{
    internal abstract class Distribution
    {
        protected List<double> echantillon;

        public abstract void CalculerDistribution();

        public abstract double CalculerMoyenneTheorique();

        public abstract double CalculerVarianceTheorique();

        public double CalculerMoyenneEmpirique()
        {
            if (echantillon.Count != 0)
            {
                double sommeValeurs = 0;

                foreach (double valeur in echantillon)
                {
                    sommeValeurs += valeur;
                }

                double moyenne = sommeValeurs / echantillon.Count;

                return moyenne;
            }
            else
            {
                Console.WriteLine("Impossible de diviser par 0");

                return 0;
            }
            
        }

        public double CalculerVarianceEmpirique()
        {
            if (echantillon.Count != 1)
            {
                double sommeEcartType = 0;

                double moyenne = CalculerMoyenneEmpirique();

                foreach (double valeur in echantillon)
                {
                    sommeEcartType += (valeur - moyenne) * (valeur - moyenne);
                }

                double variance = sommeEcartType / (echantillon.Count - 1);

                return variance;
            }
            else
            {
                Console.WriteLine("Impossible de diviser par 0");

                return 0;
            }
            
        }

        public double CalculerEcartTypeEmpirique()
        {
            double variance = CalculerVarianceEmpirique();

            double ecartType = Math.Sqrt(variance);

            return ecartType;
        }

        public double CalculerCoteZ()
        {
            if (echantillon.Count != 0)
            {
                double moyenneEmp = CalculerMoyenneEmpirique();
                double moyenneTheo = CalculerMoyenneTheorique();
                double varianceTheo = CalculerVarianceTheorique();


                double erreurStandard = Math.Sqrt(varianceTheo / echantillon.Count);

                double coteZ = (moyenneEmp - moyenneTheo) / erreurStandard;

                return coteZ;
            }
            else
            {
                Console.WriteLine("Impossible de diviser par 0");

                return 0;
            }
        }

        public void AfficherStatistiques()
        {
            Console.WriteLine();
            Console.WriteLine($"Moyenne empirique: {CalculerMoyenneEmpirique()}");
            Console.WriteLine($"Variance empirique: {CalculerVarianceEmpirique()}");
            Console.WriteLine($"Écart-Type empirique: {CalculerEcartTypeEmpirique()}");
            Console.WriteLine();
        }

        public void AfficherComparaisonsMoyennes()
        {
            Console.WriteLine();
            Console.WriteLine($"Moyenne theorique: {CalculerMoyenneTheorique()}");
            Console.WriteLine($"Moyenne empirique: {CalculerMoyenneEmpirique()}");
            Console.WriteLine($"Cote Z: {CalculerCoteZ()}");
            Console.WriteLine();

            if (Math.Abs(CalculerCoteZ()) < 2)
                Console.WriteLine("Les moyennes sont proches.");
            else
                Console.WriteLine("Les moyennes sont significativement différentes.");

            Console.WriteLine();
        }

        //Affiche la liste créer de l'échantillon
        public void AfficherEchantillon()
        {
            Console.WriteLine();
            Console.WriteLine("Affichage des donnees: ");
            Console.WriteLine("***********************");
            Console.WriteLine();

            foreach (double donnees in echantillon)
            {
                Console.Write($"{donnees:0.##}; ");
            }

            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        //sauvegarde les données de la liste dans un fichier
        public void SauvegarderFichier(string nomFichier)
        {
            using (StreamWriter fichier = new StreamWriter(nomFichier))
            {
                foreach (double donnees in echantillon)
                {
                    fichier.WriteLine(donnees);                  
                }

                Console.WriteLine("Fichier sauvegardé en mémoire.");
                Console.WriteLine();
            }
        }
    }
}
