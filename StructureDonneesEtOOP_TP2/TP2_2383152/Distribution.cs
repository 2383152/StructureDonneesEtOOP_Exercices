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


        //Affiche la liste créer
        public void AfficherEchantillion()
        {
            Console.WriteLine();
            Console.WriteLine("Affichage des donnees: ");
            Console.WriteLine();
            Console.WriteLine("***********************");

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
                    fichier.Write(donnees + ";");                  
                }

                Console.WriteLine("Fichier sauvegardé en mémoire.");
            }
        }

    }
}
