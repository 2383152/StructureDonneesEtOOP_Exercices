using Exercice07;

namespace Laboratoire07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //je dois être capable de créer le programme pour que ca fasse dequoi a partir de ce que j'ai déja

            Ferme ferme1 = new Ferme(3);

            ferme1.ajouterAnimal(new Poussin());
            ferme1.ajouterAnimal(new Chat());
            ferme1.ajouterAnimal(new Vache());

            ferme1.ecouterAnimaux(); //okkkkk, c la que ca devient vrm intéressant, on commence vrm a faire du bon polymorphisme quoi!
        }
    }
}
