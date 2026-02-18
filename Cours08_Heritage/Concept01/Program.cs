namespace Concept01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire();
            compte1.Nom = "Lol";
            compte1.Prenom = "Vrm";
            compte1.Numero = "123";
            compte1.AfficherInfoCompte();

            var compteEpargne = new CompteEpargne(); //var pour ne pas déclarer de type en particulier si on ne le connais pas
            compteEpargne.Nom = "Pineault";
            compteEpargne.Prenom = "Louise";
            compteEpargne.Numero = "5678";
            compteEpargne.TauxEpargne = 2.3;
            compteEpargne.AfficherInfoCompte();
            compteEpargne.AfficherCompteEpargne();
        }
    }
}
