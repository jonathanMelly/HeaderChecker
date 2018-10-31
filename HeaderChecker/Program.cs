using System;

namespace HeaderChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            VSProjectExplorer explorer = new VSProjectExplorer(args[0]);
            HeaderValidator validator = new HeaderValidator("etml");

            explorer.ScanForCsFile();

            explorer.Analyze(validator);


            Environment.Exit(1);//renvoie un code d'erreur (par défaut 0)
        }
    }
}
