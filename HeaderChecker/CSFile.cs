namespace HeaderChecker
{
    internal class CSFile
    {
        private string content;
        private bool valid;

        public CSFile(string content)
        {
            this.content = content;
        }

        public string Content { get { return content; }}
        public bool Valid { set { valid = value; } get { return valid; } }
    }
}