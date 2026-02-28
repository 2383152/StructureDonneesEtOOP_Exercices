namespace Exercice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création d'une équation 
            Equation equation1 = new EquationLineaire(2, 4);
            Console.WriteLine(equation1);//Appel la méthode toString() déclarée dams EquationLineaire (équivalent a faire Console.WriteLine(equation1.ToString);, mais c'est par défaut donc pas besoin d'écrir le .ToString())
            double[] solution1 = equation1.Resoudre();

            //création d'une équation quadratique

            Equation equation2 = new EquationQuadratique(1, -3, 2);
            Console.WriteLine(equation2);//Afficher la représentation de l'équation en faisant appel à la méthode ToString de EquationQuadratique
            double[] solution2 = equation2.Resoudre();

            Console.WriteLine("Les solution de l'équation " + string.Join(", ", solution2));
            
            //string.Join() est utilisé pour conxatener une séquence de chaines de caractères
            //Exemple:
            /*
             string[] mots = { "chat", "chien", "oiseau" };
             string resultat = string.Join("- ", mots);
             Console.WriteLine(resultat);//va afficher: chat- chien- oiseau
            */


        }
    }
}
