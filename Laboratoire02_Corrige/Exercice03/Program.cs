namespace Exercice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuDeCirculation feu1 = new FeuDeCirculation("Rouge", 30);
            // Afficher si le feu est rouge

            Console.WriteLine("Le feu est rouge :" + feu1.EstRouge());

            // Changer la couleur du feu de circulation
            feu1.ChangerCouleurFeu("Vert");

            //Afficher si le feu de circulation est maintenant vert

            Console.WriteLine("Le feu est vert :" + feu1.EstVert());
        }
    }
}
