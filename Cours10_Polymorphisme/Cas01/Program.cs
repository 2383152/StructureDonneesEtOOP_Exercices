namespace Cas01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f1 = new Carree(5);

            Console.WriteLine($"Le périmètre du carré est: {f1.CalculerPerimetre()}");
        }
    }
}
