namespace TP_Synthese_2383152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix = "";

            while (choix != "Q")
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

                switch (choix)
                {
                    case "O":

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Option Observateur: ");
                        Console.WriteLine();
                        Console.Write("           Veulliez fournir le numéro d'identification: ");
                        string numeroIdentification = Console.ReadLine();
                        Console.WriteLine();

                        Utilisateur observateur = new Observateur();
                        
                        if (numeroIdentification exists)


                        break;

                    case "S":
                        break;

                    case "Q":
                        break;
                }
            }
        }
    }
}
