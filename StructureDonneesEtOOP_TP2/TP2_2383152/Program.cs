using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP2_2383152
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choixNombre = 0;
            char choixLettre = ' ';

            while (choixNombre != 4)
            {
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
                                    Distribution distribution1 = new DistributionNormale(tailleEchantillion, moyenneTheorique, ecartType);
                                    distribution1.CalculerDistribution();
                                    distribution1.AfficherEchantillion();
                                    //distribution1.SauvegarderFichier("to be confirmed...");


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
                                    Distribution distribution2 = new DistributionBinomiale(tailleEchantillion, nbTotalEssais, probabiliteSucces);
                                    distribution2.CalculerDistribution();
                                    distribution2.AfficherEchantillion();
                                    //distribution2.SauvegarderFichier("to be confirmed...");

                                    break;
                            }                               
                        }
                       
                        break;

                    case 2: //Afficher les statistiques

                        while (choixLettre != 'M')
                        {
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

                                    break;

                                case 'B': //Distribution Binomiale

                                    break;
                            }
                        }
                        break;

                    case 3: //Comparer la moyenne théorique et la moyenne empirique

                        while (choixLettre != 'M')
                        {
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
                                    Console.WriteLine();
                                    break;

                                case 'B': //Distribution Binomiale

                                    break;
                            }
                        }

                        break;

                    case 4:
                        //ffectue la sauvegarde des différentes distributions dans des fichiers et affiche les noms des fichiers sauvegardés avant de fermer le programme.
                        
                        break;
                }
            }
        }
    }
}
