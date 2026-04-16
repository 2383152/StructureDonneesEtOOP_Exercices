namespace KeyConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  On met dans la classe parent tout ce qui est commun au classe enfants
            *   pour avoir du bon OOP on voudrait créer une distribution qui elle génère l'échantillion au lieu de créer un échantillion
            *       et de lui demander de générer des distributions
            *   l'échantillion est juste le résultat
            *   en OOP, les comportements = objets et la distribution = un comportement
            *   avec ma facons, un objet doit tout faire, il y a plein de if et ce n'est pas du polymorphisme
            *   la méthode oop: chaque objet a son comportement, pas de if et  polymorphisme
            *   est-ce que c'est l'échantillion qui choisi comment il est créer ou est ce qu'il est créer par qq chose d'autre
            *   distribution = chef, echantillion = plat
            *   On veut s'assurer d'ecrir le code une seule fois, la classe interface nous permetterai pas de créer la liste échantillion
            *   Interface = contrat, classe abstraite = base + comportement
            *   
            *   
            *   
            *   Classe abstraite:
            *       - classe qu'on utilise comme modèle de base, mais qu'on a pas le droit d'instancier directement
            *       - on interdit l'instanciation car la classe est incomplète a cause des méthode abstraite non défini
            *       - Une méthode abstraite va dire qu'elle sait que on doit faire un certain quelque chose, mais on ne sait pas comment
            *       - la classe abstraite sert a partager du code commun et a écrir les choses une seule fois
            *       - la classe abstraite force les classe enfants a écrir c apropre facons d'exécuter une méthode
            *       - si c'était une classe normal quelqu'un pourrais essayer d'utiliser les méthodes incomplète, mais il n'y a rien dedans
            */

            /* Méthode abstraite:
             *      - pk on créer des méthodes abstraites commune aux classes enfants: apparement ce n'est pas une question de code, mais plustot
             *          de structure qui permet ensuite l'activation du polymorphisme
             *      - C'est comme si ca me forcait a me rappeler que j'ai besoin de cette méthode la dans toute les classes enfants. Ca impose
             *          une certaine structure
             *      -méthode abstraite = contrat obligatoire
             *      - si on écrit juste les méthode dans les classe enfants, on perd de la sécurité puisque rien nous oblige a suivre une même
             *          structure, on peut manquer de cohérence si les noms sont un peu différents et on ne peut pas faire de polymorphisme
             *      - on ne créer pas la méthode pour l'utiliser dans la classe parent, mais plutot pour la forcer aux classes enfants     
             */


            /*  Dans la classe abstraite "Distribution", on va mettre tout ce que les deux sortes de distributions peuvent faire de facosn commune:
             *          - Elle peuvent générer un échantillion (liste). Si je mettais ca dans les classes enfants, je répèterai les meme choses 
             *              deux fois. Si je mets la liste private, seulement la classe distribution peut y accéder et si elle est public, tt
             *              le monde peut y accéder et on pourrais ainsi faire echantillion.Clear() dans le main, mais si elle est protected, 
             *              seulement la classe parent et les classe enfant peuvent y accéder
             */

            /* Dans la création de mon code dans le main, je vais faire Distribution d = new DistributionNormal(); et après je vais faire d.Générer()
             * Si on procède ainsi, l'objet va savoir quel type de dsitribution générer implicitement sans avoir a le préciser dans le d.Générer
             */


        }
    }
}
