using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Matrice
    {
        string nomFichier;
        public double[,] Valeurs { get; set; } //Déclaration d'un tableau a deux dimensions

        //Constructeur
        public Matrice(string nomFichier)
        {
            this.nomFichier = nomFichier;
        }

        //Charger les données du fichier dans le tableau en mémoire
        public void ChargerTableau()
        {
            if(File.Exists(nomFichier)) //Vérifie si le fichier existe
            {
                string[] lignes = File.ReadAllLines(nomFichier); //Extrait toutes les lignes du fichier et sauvegarde dans un vecteur
                int nombreLignes = lignes.Length; //donne le nombre de ligne

                int nombreColonne = lignes[0].Split(';').Length; //lignes[0].Split(';') donne un vecteur et lenght nous donne la taille du vecteur

                //allocation mémoire pour le tableau
                Valeurs = new double[nombreLignes, nombreColonne];

                //Remplissage du Tableau a partir du fichier

                for (int i = 0; i < nombreLignes; i++)
                {
                    string[] element = lignes[i].Split(";"); //Construit un vecteur de string
                    for (int j = 0; j < nombreColonne; j++)
                    {
                        Valeurs[i, j] = double.Parse(element[j]);
                    }
                }
            }

            else
            {
                Console.WriteLine("Le fichier n'existe pas");
            }

        }

        //Méthode pour afficher le tableau

        public void AfficherTableau()
        {
            int taille = Valeurs.GetLength(0); //GetLength(0);retourne le nombre de ligne d'un tableau a deux dimentsion, GetLength(1); retourne colonne

            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    Console.Write(Valeurs[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Méthode qui effectue la  multiplication de matrice et du vecteur
        public Vecteur MultiplierMatriceVecteur(Vecteur vecteur)
        {
            int taille = Valeurs.GetLength(0); //Nombre ligne du tableau
            //Vérifie si la multiplication est possible

            if(taille != vecteur.Valeurs.Length)
            {
                Console.WriteLine("Les dimensions de la matrice et du vecteur ne sont pas compatibles");
            }

            double[] resultat = new double[taille];

            for(int i = 0; i < taille; i++)
            {
                double somme = 0;
                for(int j = 0; j < taille; j++)
                {
                    somme += Valeurs[i, j] * vecteur.Valeurs[j];
                }
                resultat[i] = somme;
            }
            return new Vecteur(resultat);
        }
    }
}
