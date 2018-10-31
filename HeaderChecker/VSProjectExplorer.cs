using System;
using System.Collections.Generic;
using System.IO;

namespace HeaderChecker
{
    internal class VSProjectExplorer
    {
        private string absolutePath;
        private Boolean valid = false;
        private List<CSFile> csFiles = new List<CSFile>();

        public VSProjectExplorer(string path)
        {
            this.absolutePath = Path.GetFullPath(path);
        }

        internal void Analyze(HeaderValidator validator)
        {
            valid = true;
            foreach (CSFile file in csFiles)
            {
                bool result = validator.Validate(file.Content);
                file.Valid = result;

                if (result == false && valid == true)
                    valid = false;
            }
        }

        public void ScanForCsFile()
        {
            foreach (string file in Directory.GetFiles(absolutePath,"*.cs",SearchOption.AllDirectories))
            {
                string content = File.ReadAllText(file);
                csFiles.Add(new CSFile(content));
            }
        }

        
    }
}