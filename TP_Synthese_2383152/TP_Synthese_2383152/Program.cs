using System.Reflection;
using System.Reflection.PortableExecutable;

namespace TP_Synthese_2383152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix = "";

            while (choix != "Q")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-----SIMULATION DES MISSIONS SPATIALES-----");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Choisir une option: ");
                Console.WriteLine();
                Console.WriteLine("              (O) Observateur");
                Console.WriteLine("              (S) Scientifique");
                Console.WriteLine();
                Console.WriteLine("              (Q) Quitter");
                Console.WriteLine();
                Console.Write("  Votre choix: ");
                choix = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (choix)
                {
                    case "O":

                        Systeme systemeObservateur = new Systeme();
                        
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Option Observateur: ");
                        Console.WriteLine();
                        Console.Write("           Veulliez fournir le numéro d'identification: ");
                        string entree = Console.ReadLine();
                        Console.WriteLine();                       
                        
                        while (systemeObservateur.ConnexionUtilisateur(entree) != "observateur" && entree != "M") 
                        {
                            Console.WriteLine("Numéro d'identification invalide veuillez réessayez ou entrer (M) pour revenir au menu principale.");
                            Console.Write("           Veulliez fournir le numéro d'identification: ");
                            entree = Console.ReadLine();
                            Console.WriteLine();
                            
                        }

                        while (entree != "M" && choix != "Q") //a retravaillé 
                        {
                            Observateur observateur = new Observateur(entree);

                            observateur.AfficherProfil();

                            Console.WriteLine("              (RM) Recherche d'une mission");
                            Console.WriteLine("              (LM) Liste des missions");
                            Console.WriteLine("              (RS) Rechercher un scientifique");
                            Console.WriteLine("              (LS) Liste des scientifiques");
                            Console.WriteLine("              (LI) Liste des instruments de mesures");
                            Console.WriteLine();
                            Console.WriteLine("               (Q) Quitter");
                            Console.WriteLine();
                            Console.Write("  Votre choix: ");
                            choix = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            Systeme systemeMission = new Systeme();
                            systemeMission.ChargerDonnees("Donnees.csv");
                       
                            switch (choix)
                            {
                                case "RM":

                                    Console.WriteLine("Option recherche d'une mission: ");
                                    Console.WriteLine();
                                    Console.Write("           Veulliez fournir le numéro de référence: ");
                                    entree = Console.ReadLine();
                                    Console.WriteLine();

                                    while (observateur.RechercherDansFichier(entree) == false && entree != "O" && entree != "M")
                                    {
                                             Console.WriteLine("Numéro de référence invalide veuillez réessayez ou entrer (O) pour revenir au menu observateur.");
                                             Console.Write("           Veulliez fournir le numéro d'identification: ");
                                             entree = Console.ReadLine();
                                             Console.WriteLine();
                                    }

                                    if (entree.ToUpper() != "O")
                                    {      
                                        Mission mission = new Mission(entree);

                                        mission.AfficherInfo();

                                        Console.Write("Pour revenir au menu principal, entrer (M): ");
                                        entree = Console.ReadLine().ToUpper();
                                        Console.WriteLine();
                                    }

                                    break;

                                case "LM":

                                    Console.WriteLine("Option liste des missions: ");
                                    Console.WriteLine();

                                    observateur.AfficherListeMission();

                                    Console.Write("Pour revenir au menu principal, entrer (M): ");
                                    entree = Console.ReadLine().ToUpper();
                                    Console.WriteLine();

                                    break;

                                case "RS":

                                    Console.WriteLine("Option recherche d'un scientifique: ");
                                    Console.WriteLine();
                                    Console.Write("           Veulliez fournir le numéro de matricule: ");
                                    entree = Console.ReadLine();
                                    Console.WriteLine();

                                    if(observateur.RechercherDansFichier(entree) == false)
                                    {
                                        Console.WriteLine("Ce scientifique n'existe pas.");
                                    }
                                    else
                                    {
                                        Scientifique scientifique = new Scientifique(entree);

                                        scientifique.AfficherInfo();

                                        Console.Write("Pour revenir au menu principal, entrer (M): ");
                                        entree = Console.ReadLine().ToUpper();
                                        Console.WriteLine();
                                    }

                                    break;

                                case "LS":

                                    Console.WriteLine("Option liste des scientifiques: ");
                                    Console.WriteLine();

                                    observateur.AfficherListeScientifique();

                                    Console.Write("Pour revenir au menu principal, entrer (M): ");
                                    entree = Console.ReadLine().ToUpper();
                                    Console.WriteLine();

                                    break;

                                case "LI":
                                    Console.WriteLine("Option liste des instruments: ");
                                    Console.WriteLine();
                                    Console.Write("           Veulliez fournir le numéro de référence: ");
                                    entree = Console.ReadLine();
                                    Console.WriteLine();

                                    if (observateur.RechercherDansFichier(entree) == false)
                                    {
                                        Console.WriteLine("Ce scientifique n'existe pas.");
                                    }
                                    else
                                    {
                                        Scientifique scientifique = new Scientifique(entree);

                                        scientifique.AfficherInfo();

                                        Console.Write("Pour revenir au menu principal, entrer (M): ");
                                        entree = Console.ReadLine().ToUpper();
                                        Console.WriteLine();
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Veuillez entrer un choix valide");
                                    Console.WriteLine();

                                    break;
                            }
                        }
                            break;




                    case "S":
                        Systeme systemeScientifique = new Systeme();

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Option Observateur: ");
                        Console.WriteLine();
                        Console.Write("           Veulliez fournir le matricule: ");
                        entree = Console.ReadLine();
                        Console.WriteLine();

                        while (systemeScientifique.ConnexionUtilisateur(entree) != "scientifique" && entree != "M")
                        {
                            Console.WriteLine("Numéro d'identification invalide veuillez réessayez ou entrer (M) pour revenir au menu principale.");
                            Console.Write("           Veulliez fournir le numéro d'identification: ");
                            entree = Console.ReadLine();
                            Console.WriteLine();

                        }

                        while (entree != "M" && choix != "Q") //a retravaillé 
                        {
                            Scientifique scientifique = new Scientifique(entree);

                            scientifique.AfficherProfil();

                            Console.WriteLine("              (GP) Gestion des profiles");
                            Console.WriteLine("              (GO) Gestion des objets");
                            Console.WriteLine("              (GM) Gestion des missions");
                            Console.WriteLine("              (GI) Gestion des instruments de mesures");
                            Console.WriteLine("              (SM) Simulation des mesures");
                            Console.WriteLine();
                            Console.WriteLine("               (Q) Quitter");
                            Console.WriteLine();
                            Console.Write("  Votre choix: ");
                            choix = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            Systeme systemeMission = new Systeme();
                            systemeMission.ChargerDonnees("Donnees.csv");

                            switch (choix)
                            {
                                case "GP":
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
                                    choix = Console.ReadLine().ToUpper();
                                    Console.WriteLine();

                                    switch(choix)
                                    {
                                        case "AO":

                                            Console.WriteLine("Option ajout d'un observateur");
                                            Console.WriteLine();

                                            while (entree != "M")
                                            {
                                                scientifique.AjouterObservateur();

                                                Console.Write("Pour revenir au menu principal, entrer (M), sinon, presser \"entrer\": ");
                                                entree = Console.ReadLine().ToUpper();
                                                Console.WriteLine();
                                            }
                                            
                                            break;

                                        case "AS":

                                            Console.WriteLine("Option ajout d'un scientidfique");

                                            while (entree != "M")
                                            {
                                                scientifique.AjouterScientifique();

                                                Console.Write("Pour revenir au menu principal, entrer (M), sinon, presser \"entrer\": ");
                                                entree = Console.ReadLine().ToUpper();
                                                Console.WriteLine();
                                            }

                                            break;

                                        default:

                                            Console.WriteLine("Veuillez entrer un choix valide");
                                            Console.WriteLine();
                                            break;
                                    }

                                    break;

                                case "GO":
                                    break;

                                case "GM":
                                    break;

                                case "GI":

                                    
                                    break;

                                case "SM":
                                   
                                    break;

                                default:

                                    Console.WriteLine("Veuillez entrer un choix valide");
                                    Console.WriteLine();

                                    break;
                            }
                        }
                        break;

                    case "Q":
                        break;

                    default:
                        Console.WriteLine("Veuillez entrer un choix valide");
                        break;
                }
            }
        }
    }
}
