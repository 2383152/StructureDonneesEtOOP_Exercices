namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrice A = new("Donnees.csv");

            A.ChargerTableau();
            A.AfficherTableau();

            Console.WriteLine("Affichage du vecteur");

            Vecteur B = new("DonneesVecteurs.csv");
            B.ChargerVecteur();
            B.AfficherVecteur();

            Console.WriteLine("Multiplication de la matrice A et B ");
            Vecteur C =A.MultiplierMatriceVecteur(B);
            C.AfficherVecteur();
            C.SauvegardeVecteur();

        }
    }
}
