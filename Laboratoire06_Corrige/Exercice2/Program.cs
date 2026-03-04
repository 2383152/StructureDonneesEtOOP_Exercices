namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formule formule = new Formule();
            Console.WriteLine("Calculs mathématiques");
            formule.CalculerAireCercle(7);
            formule.CalculerFactorielle(5);
            Console.WriteLine("*************************");


            Console.WriteLine("Calculs physique");
            formule.EnergieCinetique(70, 15); //masse de 70kg et vitesse de 15m/s
            formule.ForceGravitationnelle(5.972e24, 7.348e22, 384400000); //e = exposant
            Console.WriteLine("*************************");

            Console.WriteLine("Gestion des tableau");
            double[,] tableau = { { 3.14, 35.6 }, { 70, 105 } };
            formule.AfficherTableau(tableau);
            formule.ConvertiTableauEnListe(tableau);
            Console.WriteLine("*************************");
        }
    }
}
