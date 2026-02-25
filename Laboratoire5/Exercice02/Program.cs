namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Examen: peut pas faire de polymorphisme sans héritage


            //Création liste de formes
            List<Forme> formes = new List<Forme>
            {
                new Cercle(8),
                new Rectangle(4, 5),
                new Triangle(2, 7)
            };

            //Calculer et afficher l'aire de chaque forme
            //Equivalent à: for(int i = 0; i < formes.Count; i++) 
            foreach (/* int = */ Forme /* i = */ figure /* formes.Count = */ in /* list choisi = */ formes)
            {
                Console.WriteLine($"Aire de la forme: {figure.CalculerAire():F2}"); //F2 = deux chiffres apres la virgule
            }
        }
    }
}
