using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Systeme
    {
        protected List<double> liste;
        public string[,] tableau { get; private set; }

        //Charge les données du fichier dans un tableau contenu dans la classe
        public void ChargerDonnees(string nomFichier)
        {
            string[] lignes = File.ReadAllLines(nomFichier);

            int nombreLignes = lignes.Length;
            int nombreColonne = lignes[0].Split(';').Length;

            tableau = new string[nombreLignes, nombreColonne];


            for (int i = 0; i < nombreLignes; i++)
            {
                string[] element = lignes[i].Split(";");

                for (int j = 0; j < nombreColonne; j++)
                {
                    tableau[i, j] = (element[j]);
                }
            }
        }

        public void SauvegarderDonnees(string nomFichier) //a retravailler
        {
            using (StreamWriter fichier = new StreamWriter(nomFichier))
            {
                foreach (double donnees in liste)
                {
                    fichier.WriteLine(donnees);
                }

                Console.WriteLine("Fichier sauvegardé en mémoire.");
                Console.WriteLine();
            }
        }

        public string ConnexionUtilisateur(string id)
        {
            ChargerDonnees("Donnees.csv");

            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    if (tableau[i, j] == id)
                    {
                        //return true;
                        //if (tableau[i, tableau.GetLength(1)].Contains(";;"))
                            return "observateur";

                        //else if (tableau[i, tableau.GetLength(1)].Contains(";;;;"))
                            //return "observateur";                     
                    }                       
                }
            }
            //return false;
            return "invalide";
        }
    }
}
