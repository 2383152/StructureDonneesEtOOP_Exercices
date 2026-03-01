namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuDeCirculation feu1 = new FeuDeCirculation("rouge", 10);

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());

            feu1.ChangerCouleurVert();

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());




            FeuDeCirculation feu2 = new FeuDeCirculation("jaune", 10);

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());

            feu2.ChangerCouleurRouge();

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());
        }
    }
}
