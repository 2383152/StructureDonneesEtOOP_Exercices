namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Option 1:");
            Console.WriteLine("N- Distribution Normale");
            Console.WriteLine();

            Console.Write("Donner la taille de l'échantillion: ");
            bool estValeurValide = int.TryParse(Console.ReadLine(), out int tailleEchantillion);

            Console.Write("Donner la moyenne théorique: ");
            estValeurValide = double.TryParse(Console.ReadLine(), out double moyenneTheorique);

            Console.Write("Donner la écart-type: ");
            estValeurValide = double.TryParse(Console.ReadLine(), out double ecartType);



            //Distribution normale
            Random random = new Random();
            List<double> distributionNormal = new List<double>();

            for (int i = 0; i < tailleEchantillion; i++)
            {
                double u1 = random.NextDouble(); //déjà entre 0 et 1 quand rien entre ()
                double u2 = random.NextDouble();

                double z = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);

                double valeur = moyenneTheorique + ecartType * z;
                distributionNormal.Add(valeur);
            }

            foreach (double valeur in distributionNormal)
            {
                Console.WriteLine(valeur);
            }














            //classe echantillion??

            /*
            string NomFichier { get; set; }
            public List<double> _Echantillion { get; set; }

            public Echantillion(string nomFichier)
            {
            this.NomFichier = nomFichier;
            }
            */

        }
    }
}
