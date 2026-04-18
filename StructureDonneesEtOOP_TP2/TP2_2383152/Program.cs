using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP2_2383152
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choixNombre = -1;
            char choixLettre = ' ';

            string nomFichier = " ";
            List<string> fichiersSauvegarder = new List<string>();
            Distribution distributionNormale = new DistributionNormale(-1, -1, -1 );
            Distribution distributionBinomiale = new DistributionBinomiale(-1, -1, -1);

            while (choixNombre != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Simulateur de Distributions Statistiques!");
                Console.WriteLine("*****************************************");
                Console.WriteLine("Option 1- Générer un échantillion");
                Console.WriteLine("Option 2- Afficher les statistiques d'un échantillion");
                Console.WriteLine("Option 3- Comparer la moyenne théorique et la moyenne empirique");
                Console.WriteLine("Option 4- Quitter");

                Console.WriteLine();
                Console.Write("Option choisi: ");
                bool estChoixValide = int.TryParse(Console.ReadLine(), out choixNombre);

                switch (choixNombre)
                {
                    case 1: //Générer un échantillion

                        while (choixLettre != 'M')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Génération de l'échantillion");
                            Console.WriteLine("****************************");
                            Console.WriteLine("N- Distribution Normale");
                            Console.WriteLine("B- Distribution Binomiale");
                            Console.WriteLine("M- Menu Principale");

                            Console.WriteLine();
                            Console.Write("Option choisi: ");
                            estChoixValide = char.TryParse(Console.ReadLine(), out choixLettre);

                            switch (choixLettre)
                            {
                                case 'N': //Distribution Normale

                                    //Demander les donner nécéssaires
                                    Console.Write("Donner la taille de l'échantillion: ");
                                    bool estValeurValide = int.TryParse(Console.ReadLine(), out int tailleEchantillion);

                                    Console.Write("Donner la moyenne théorique: ");
                                    estValeurValide = double.TryParse(Console.ReadLine(), out double moyenneTheorique);

                                    Console.Write("Donner la écart-type: ");
                                    estValeurValide = double.TryParse(Console.ReadLine(), out double ecartType);

                                    //Calculer, afficher et sauvegarder
                                    distributionNormale = new DistributionNormale(tailleEchantillion, moyenneTheorique, ecartType);

                                    distributionNormale.CalculerDistribution();
                                    distributionNormale.AfficherEchantillon();

                                    nomFichier = "DistributionNormale.csv";
                                    fichiersSauvegarder.Add(nomFichier);
                                    distributionNormale.SauvegarderFichier(nomFichier);


                                    break;

                                case 'B': //Distribution Binomiale

                                    //Demander les donner nécéssaires
                                    Console.Write("Donner la taille de l'échantillion: ");
                                    estValeurValide = int.TryParse(Console.ReadLine(), out tailleEchantillion);

                                    Console.Write("Donner le nombre total d'essais: ");
                                    estValeurValide = double.TryParse(Console.ReadLine(), out double nbTotalEssais);

                                    Console.Write("Donner la probabilité de succès: ");
                                    estValeurValide = double.TryParse(Console.ReadLine(), out double probabiliteSucces);

                                    //Calculer, afficher et sauvegarder
                                    distributionBinomiale = new DistributionBinomiale(tailleEchantillion, nbTotalEssais, probabiliteSucces);

                                    distributionBinomiale.CalculerDistribution();
                                    distributionBinomiale.AfficherEchantillon();

                                    nomFichier = "DistributionBinomiale.csv";
                                    fichiersSauvegarder.Add(nomFichier);
                                    distributionBinomiale.SauvegarderFichier(nomFichier);

                                    break;
                            }                               
                        }
                       
                        break;

                    case 2: //Afficher les statistiques

                        while (choixLettre != 'M')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Afficher les statistiques");
                            Console.WriteLine("****************************");
                            Console.WriteLine("N- Distribution Normale");
                            Console.WriteLine("B- Distribution Binomiale");
                            Console.WriteLine("M- Menu Principale");

                            Console.WriteLine();
                            Console.Write("Option choisi: ");
                            estChoixValide = char.TryParse(Console.ReadLine(), out choixLettre);

                            switch (choixLettre)
                            {
                                case 'N': //Statistique de la distribution Normale

                                    if (!File.Exists("DistributionNormale.csv"))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Le fichier n'existe pas.");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        distributionNormale.AfficherStatistiques();                                       
                                    }
                                        
                                        break;

                                case 'B': //Statistique de la distribution Binomiale

                                    if (!File.Exists("DistributionBinomiale.csv"))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Le fichier n'existe pas.");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        distributionBinomiale.AfficherStatistiques();                                 
                                    }
                                    break;
                            }
                        }
                        break;

                    case 3: //Comparer la moyenne théorique et la moyenne empirique

                        while (choixLettre != 'M')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comparaisons des moyenne");
                            Console.WriteLine("****************************");
                            Console.WriteLine("N- Distribution Normale");
                            Console.WriteLine("B- Distribution Binomiale");
                            Console.WriteLine("M- Menu Principale");

                            Console.WriteLine();
                            Console.Write("Option choisi: ");
                            estChoixValide = char.TryParse(Console.ReadLine(), out choixLettre);

                            switch (choixLettre)
                            {
                                case 'N': //Statistique de la distribution Normale

                                    if (!File.Exists("DistributionNormale.csv"))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Le fichier n'existe pas.");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        distributionNormale.AfficherComparaisonsMoyennes();
                                    }

                                    break;

                                case 'B': //Statistique de la distribution Binomiale

                                    if (!File.Exists("DistributionBinomiale.csv"))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Le fichier n'existe pas.");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        distributionBinomiale.AfficherComparaisonsMoyennes();
                                    }
                                    break;
                            }
                        }

                        break;

                    case 4:

                        Console.WriteLine("Fichier sauvegarder: ");
                        foreach(string nom in fichiersSauvegarder)
                        {
                            Console.WriteLine(nom);
                        }
                        
                        break;
                }
            }
        }
    }
}
