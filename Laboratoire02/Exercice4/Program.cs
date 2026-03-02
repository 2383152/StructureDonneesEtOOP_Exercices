namespace Exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime heureDepart1 = new DateTime(2026, 03, 01, 19, 40, 00);
            Avion avion1 = new Avion(5673, "France", heureDepart1);

            avion1.AfficherInfo();
            Console.WriteLine("L'avion 1 est en retard: " + avion1.EstEnRetard());
            Console.WriteLine($"Le retard est de {avion1.CalculerTempsRetard()} minutes");

            Console.WriteLine();

            DateTime heureDepart2 = new DateTime(2070, 03, 01, 8, 40, 00);
            Avion avion2 = new Avion(0000, "Mars", heureDepart2);

            avion2.AfficherInfo();
            Console.WriteLine("L'avion 1 est en retard: " + avion2.EstEnRetard());
            Console.WriteLine($"Le retard est de {avion2.CalculerTempsRetard()} minutes");

        }
    }
}
