namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cube");
            Solide cube = new Solide(20, 20, "carree");
            cube.AfficherInfoSolide();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Console.WriteLine("eau");
            Liquide eau = new Liquide(30, 40, "bleu");
            eau.AfficherInfoLiquide();
        }
    }
}
