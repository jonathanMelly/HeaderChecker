//Auteur : JMY
//Date : 2018
using System;

namespace HeaderChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            VSProjectExplorer explorer = new VSProjectExplorer(args[0]);
            HeaderValidator validator = new HeaderValidator("etml");

            //Parcourt le système de fichier
            explorer.ScanForCsFile();

            //Analyse les entêtes
            explorer.Analyze(validator);

            //Affichage des résultats
            foreach(CSFile csFile in explorer.CsFiles)
            {
                Console.WriteLine("{0} -> {1}",csFile.Name,csFile.Valid?"OK":"KO");
            }
            Console.WriteLine("Résultat pour {1} :{0}",explorer.Valid,explorer.AbsolutePath);

            Console.WriteLine("\n\nAppuyez sur une touche pour terminer");
            Console.ReadLine();

            Environment.Exit(explorer.Valid?0:1);//renvoie un code cohérent
        }
    }
}
