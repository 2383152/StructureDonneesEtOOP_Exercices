using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Vecteur
    {
        string nomFichier;
        public double[] Valeurs {  get; set; } //Déclarer le vecteur pour sauvegarder en mémoire les données du fichier

        //Constructeur
        public Vecteur(string nomFichier)
        {
            this.nomFichier = nomFichier;
        }

        //Constructeur pour construire l'objet a partir d'un vecteur
        public Vecteur(double[] valeurs)
        {
            Valeurs = valeurs; //constructeur de recopie
        }


        //Méthode pour remplir le vecteur a partir du fichier

        public void ChargerVecteur()
        {
            string[] lignes = File.ReadAllLines(nomFichier);
            string[] elements = lignes[0].Split(";");

            Valeurs = new double[elements.Length]; //allocation mémoire

            for (int i = 0; i < Valeurs.Length; i++)
            {
                Valeurs[i] = double.Parse(elements[i]); 
            }   
        }

        public void AfficherVecteur()
        {
            for(int i = 0; i < Valeurs.Length; i++)
            {
                Console.Write(Valeurs[i] + "\t");
            }
            Console.WriteLine();        
        }

        //Méthode pour sauvegarder le vecteur dans le fichier
        public void SauvegardeVecteur()
        {
            using (StreamWriter fichierSorti = new StreamWriter("Resultat.csv"))
            {
                for(int i = 0;i < Valeurs.Length;i++)
                {
                    fichierSorti.WriteLine(Valeurs[i] );
                }
            }

            Console.WriteLine("Résulltats sauvegardés dans le fichier Resultat.csv");
        }

    }
}
