namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valeurs nouvelleValeur = new Valeurs();

            nouvelleValeur.LectureFichier();//charge les données du fichier en mémoire
            nouvelleValeur.CalculerVitesse(); //Appel de la méthode pour calculer la vitesse
            nouvelleValeur.EcritureFichier(); //Appel de la méthode pour sauvegarder dans le fichier


        }
    }
}
