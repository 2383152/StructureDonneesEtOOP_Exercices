using System.Numerics;

namespace Exercice01_essai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, -2);

            Complex complex2 = new Complex(5, -6);

            Console.WriteLine(complex1.AfficherValeur);
            Console.WriteLine(complex1.GetMagnitude);
            Console.WriteLine(complex2.AfficherValeur);
            Console.WriteLine(complex2.GetMagnitude);

            complex1.Sum(complex2);

            //afficher la sum:
            Console.WriteLine(complex1.AfficherValeur);
        }
    }
}
