namespace Exercice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création cercle en mouvement

            Console.WriteLine("Cas 1");
            CercleEnMouvement cercle1 = new CercleEnMouvement(10, 15, 5, 3);
            Console.WriteLine("État du cercle en mouvement: ");
            cercle1.AfficherEtat();

            Console.WriteLine("Cas 2");
            CorpsEnMouvement cercle2 = new CercleEnMouvement(10, 15, 5, 3);
            Console.WriteLine("État du cercle en mouvement: ");
            cercle2.AfficherEtat();


        }
    }
}
