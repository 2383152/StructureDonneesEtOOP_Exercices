namespace Exercice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Entrer le b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Entrer le c: ");
            double c = double.Parse(Console.ReadLine());

            Equation eq1 = new Equation(a, b, c);

            eq1.AfficherEquationQuadratique();
            eq1.CalculerRacine();
        }
    }
}
