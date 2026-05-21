using System;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----SIMULATION DES MISSIONS SPATIALES-----");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Choisir une option: ");
            Console.WriteLine();
            Console.WriteLine("              (O) Observateur");
            Console.WriteLine("              (S) Scientifique");
            Console.WriteLine();
            Console.WriteLine("              (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Option Observateur: ");
            Console.WriteLine();
            Console.Write("           Veulliez fournir le numéro d'identification: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Observateur: ");
            Console.WriteLine("        Numero d'idendification: ");
            Console.WriteLine("        Nom: ");
            Console.WriteLine("        Date de naissance");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("              (RM) Recherche d'une mission");
            Console.WriteLine("              (LM) Liste des missions");
            Console.WriteLine("              (RS) Rechercher un scientifique");
            Console.WriteLine("              (LI) Liste des instruments de mesures");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Option Scientifique: ");
            Console.WriteLine();
            Console.Write("           Veulliez fournir le numéro matricule: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Scientifique: ");
            Console.WriteLine("        Numero matricule: ");
            Console.WriteLine("        Nom: ");
            Console.WriteLine("        Date de naissance");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Résumé profil");
            Console.WriteLine();
            Console.WriteLine("        NTotal des missions affectées: ");
            Console.WriteLine("        Catégorie Planète: ");
            Console.WriteLine("        Catégorie Étoile: ");
            Console.WriteLine("        Catégorie Satélite: ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("              (GP) Gestion des profiles");
            Console.WriteLine("              (GO) Gestion des objets");
            Console.WriteLine("              (GM) Gestion des missions");
            Console.WriteLine("              (GI) Gestion des instruments de mesures");
            Console.WriteLine("              (SM) Simulation des mesures");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gestion des profils: ");
            Console.WriteLine();
            Console.WriteLine("              (AO) Ajout d'un observateur");
            Console.WriteLine("              (AS) Ajout d'un scientifique");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gestion des objets: ");
            Console.WriteLine();
            Console.WriteLine("              (PL) Planètes");
            Console.WriteLine("              (ET) Étoiles");
            Console.WriteLine("              (SA) Satélite");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gestion des missions: ");
            Console.WriteLine();
            Console.WriteLine("              (AM) Ajouter une mission");
            Console.WriteLine("              (SM) Supprimé une mission");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gestion des instruments de mesures: ");
            Console.WriteLine();
            Console.WriteLine("              (IO) Instruments d'observation");
            Console.WriteLine("              (IA) Instruments d'analyse");
            Console.WriteLine();
            Console.WriteLine("               (Q) Quitter");
            Console.WriteLine();
            Console.Write("  Votre choix: ");
            Console.WriteLine();
        }
    }
}
