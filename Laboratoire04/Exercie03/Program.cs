namespace Exercie03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle cercle = new Cercle(2, 10, 4, 20);
            Rectangle rectangle = new Rectangle(20, 30, 4, 6, 70);

            cercle.AfficherEtat();

            Console.WriteLine();

            rectangle.AfficherEtat();
        }
    }
}
