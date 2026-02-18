namespace Concept02 //avec constructeur paramétrique (défini)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteEpargne epargne1 = new CompteEpargne(2.4, "mari", "gau");
            epargne1.AfficherInfo();

            CompteBancaire compte1 = epargne1;
        }
    }
}
