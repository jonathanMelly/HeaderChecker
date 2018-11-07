namespace HeaderChecker
{
    internal class CSFile
    {
        private string content;
        private bool valid;
        private string name;

        public CSFile(string name,string content)
        {
            this.content = content;
            this.name = name;
        }

        public string Content { get { return content; }}
        public bool Valid { set { valid = value; } get { return valid; } }

        public string Name { get => name; }
    }
}