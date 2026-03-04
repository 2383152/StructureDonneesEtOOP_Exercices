namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IvehiculePhysique> vehicules = new List<IvehiculePhysique>();

            Voiture voiture = new Voiture("Toyota", 4, 1500, 20, 100000);
            Moto moto = new Moto("Yamaha", 600, 200, 30, 50000);

            vehicules.Add(moto); //ajoute la moto
            vehicules.Add(voiture); //ajoute la voiture

            //for(int = 0; i < vehicules.Count; i++)
            foreach(var automobile in vehicules)
            {
                automobile.Demarrer();
                automobile.AfficherInfo();
                Console.WriteLine($"Energie cinétique: {automobile.CalculerEnergieCinetique()}joules");
                Console.WriteLine($"Puissance du moteur: {automobile.CalculerPuissance()}watts");
                Console.WriteLine($"Accélération pour une force de 1000N: {automobile.CalculerAcceleration(1000)}m/s");
                automobile.Arreter();
                Console.WriteLine("----------------------------------");

            }
        }
    }
}
