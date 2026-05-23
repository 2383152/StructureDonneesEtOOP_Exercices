using System.Reflection;

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

                        Systeme systemeUtilisateur = new Systeme();
                        
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Option Observateur: ");
                        Console.WriteLine();
                        Console.Write("           Veulliez fournir le numéro d'identification: ");
                        string entree = Console.ReadLine();
                        Console.WriteLine();                       
                        
                        while (systemeUtilisateur.ConnexionUtilisateur(entree) != "observateur" && entree != "M") 
                        {
                            Console.WriteLine("Numéro d'identification invalide veuillez réessayez ou entrer (M) pour revenir au menu principale.");
                            Console.Write("           Veulliez fournir le numéro d'identification: ");
                            entree = Console.ReadLine();
                            Console.WriteLine();
                            
                        }

                        while (entree != "M" && choix != "Q") //a retravaillé 
                        {
                            Observateur observateur = new Observateur(entree);

                            observateur.AfficherInfo();

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

                                    observateur.AfficherListeScientifique();

                                    Console.Write("Pour revenir au menu principal, entrer (M): ");
                                    entree = Console.ReadLine().ToUpper();
                                    Console.WriteLine();

                                    break;

                                case "LI":
                                    break;

                                default:
                                        Console.WriteLine("Veuillez entrer un choix valide");
                                        break;
                            }
                        }
                            break;

                    case "S":
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
