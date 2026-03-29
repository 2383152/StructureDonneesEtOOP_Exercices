namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Forme> formes = new List<Forme>()
            {
                new Cercle(4, "cercle 1"),
                new Rectangle(10, 5, "rectangle 1"),
                new Triangle(3, 4, "triangle 1")
            };

            foreach (Forme forme in formes)
            {
                Console.WriteLine(forme.CalculerAire());
            }
        }
    }
}
