namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule voiture = new Vehicule(20, 30, 50, "Corolla");
            voiture.AfficherInfo();

            Console.WriteLine();
            Console.WriteLine();

            Projectile balllon = new Projectile(40, 6, 30, 15);
            balllon.AfficherInfo();

            Console.WriteLine();
            double nouvellPosition = balllon.CalculerTempsNouvellePosition(20);
            Console.WriteLine("Après 20 sec le ballon se trouve à: " + nouvellPosition + "m");
        }
    }
}
