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

            //Corrigé
            feu1.ChangerCouleur("jaune");

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());




            FeuDeCirculation feu2 = new FeuDeCirculation("jaune", 10);

            Console.WriteLine("la couleur est verte: " + feu2.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu2.EstCouleurRouge());

            feu2.ChangerCouleurRouge();

            //Corrigé
            feu2.ChangerCouleur("vert");

            Console.WriteLine("la couleur est verte: " + feu1.EstCouleurVerte());
            Console.WriteLine("la couleur est rouge: " + feu1.EstCouleurRouge());
        }
    }
}
