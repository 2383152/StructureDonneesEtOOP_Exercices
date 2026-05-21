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

                        systemeObservateur.ChargerDonnees("Donnees.csv");
                        
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Option Observateur: ");
                        Console.WriteLine();
                        Console.Write("           Veulliez fournir le numéro d'identification: ");
                        string idObservateur = Console.ReadLine();
                        Console.WriteLine();                       
                        
                        while (systemeObservateur.ConnexionUtilisateur(idObservateur) == false && idObservateur != "M") // while le num id n'existe pas, but idk how to do that yet
                        {
                            Console.WriteLine("Numéro d'identification invalide veuillez réessayez ou entrer (M) pour revenir au menu principale.");
                            Console.Write("           Veulliez fournir le numéro d'identification: ");
                            idObservateur = Console.ReadLine();
                            Console.WriteLine();
                            
                        }

                        if (idObservateur != "M") //a retravaillé
                        {
                            Utilisateur observateur = new Observateur(idObservateur);

                            observateur.AfficherInfo();

                            Console.WriteLine("              (RM) Recherche d'une mission");
                            Console.WriteLine("              (LM) Liste des missions");
                            Console.WriteLine("              (RS) Rechercher un scientifique");
                            Console.WriteLine("              (LI) Liste des instruments de mesures");
                            Console.WriteLine();
                            Console.WriteLine("               (Q) Quitter");
                            Console.WriteLine();
                            Console.Write("  Votre choix: ");
                            choix = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            while (choix != "Q")
                            switch(choix)
                            {
                                case "RM":
                                    break;

                                case "LM":
                                    break;

                                case "RS":
                                    break;

                                case "LI":
                                    break;

                                default:
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
