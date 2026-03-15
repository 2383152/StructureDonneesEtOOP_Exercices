using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Formule : IMathematique, IPhysique, IGestionTableaux
    {

        const double G = 6.67430e-11;
        
        //Définiton des méthodes de l'interface IMathématique

        public double CalculerAireCercle(double rayon)
        {
            double aire = Math.PI * rayon * rayon;
            Console.WriteLine($"Aire du cercle est: {aire}");
            return aire;
        }

        public int CalculerFactorielle(int nombre)
        {
            int resultat = 1;

            for(int i = 1; i <= nombre; i++)
            {
                resultat *= i;

                Console.WriteLine($"Le factorielle du nombre: {nombre}: {resultat}");
            }

            return resultat;
        }

        //définiton des méthodes de l'interface de Iphysique
        public double EnergieCinetique(double masse, double vitesse)
        {
            double energie = 0.5 * masse * Math.Pow(vitesse, 2);
            Console.WriteLine($"Energie Cinétique: {energie}");
            return energie;
        }

        public double ForceGravitationnelle(double masse1, double masse2, double distance)
        {
            double force = G * (masse1 * masse2) / Math.Pow(distance, 2);
            Console.WriteLine($"Force gravitationnelle: {force} N");
            return force;
        }

        //Méthode de l'interface IGestionTableaux
        public void AfficherTableau(double[,] tableau)
        {
            Console.WriteLine("Tableau des résultats");

            for(int i = 0; i < tableau.GetLength(0); i++) //.GetLength(0) = nb de lignes
            {
                for(int j = 0; j < tableau.GetLength(1); j++) // GetLength(1) = nb colonne
                {
                    Console.Write(tableau[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public List<double> ConvertiTableauEnListe(double[,] tableau)
        {
            List<double> listeTableau = new List<double>();

            for(int i = 0;i < tableau.GetLength(0);i++)
            {
                for (int j = 0;j < tableau.GetLength(1);j++)
                {
                    listeTableau.Add(tableau[i,j]);
                }
            }
            Console.WriteLine("Tableau converti en liste");

            //Afficher les éléments de la liste
            foreach(var element in listeTableau)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine();

            return listeTableau;
        }

    }
}
