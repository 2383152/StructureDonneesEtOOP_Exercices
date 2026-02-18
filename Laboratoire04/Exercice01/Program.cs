namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solide cube = new Solide(20, 30, 50, "cube", "carrée");
            cube.AffichageInfoSolide();

            ObjetPhysique solide1 = cube;

            Liquide eau = new Liquide(10, 40, 60, "eau", "bleu");
            eau.AffichageInfoLiquide();

            ObjetPhysique liquide1 = eau;
        }
    }
}
