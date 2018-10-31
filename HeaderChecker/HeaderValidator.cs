using System;

namespace HeaderChecker
{
    internal class HeaderValidator
    {
        private string name;

        public HeaderValidator(string name)
        {
            this.name = name;
        }

        public bool Validate(string fileContent)
        {
            string[] lines = fileContent.Split(new string[] { "\r\n", "\r", "\n" },StringSplitOptions.None);

            return lines[0].StartsWith("Auteur") && lines[1].StartsWith("Date");
        }
    }
}