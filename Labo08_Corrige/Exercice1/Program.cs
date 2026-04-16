namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonnee abonnee1 = new Abonnee(1, "something", "someone", "something@gmail.com");
            Livre livre1 = new Livre(101, "A cool book", "by an author", "Book");

            //emprunt d'un live
            if(abonnee1.PeutEmpreuter())
            {
                Emprunt emprunt1 = new Emprunt(1, abonnee1, livre1);
                abonnee1.AjouterEmprunt(emprunt1);
                Console.WriteLine($"Le livre {livre1.Titre} a été emprunter par {abonnee1.Nom}");
            }

            //Tentative de retour du livre
            abonnee1.RetournerLivre(livre1);
        }
    }
}
