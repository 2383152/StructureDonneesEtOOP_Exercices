namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(4, 2);
            Console.WriteLine("Le nombre est " + c1.AfficherValeur());
            Console.WriteLine("La magnitude est " + c1.CalculerMagnitude());

            //Addition de deux nombres complex

            Complex c2 = new Complex(-4, 2);
            c1.Sum(c2);
            Console.WriteLine("Affichage de deux nombre: " + c1.AfficherValeur());
        }
    }
}
