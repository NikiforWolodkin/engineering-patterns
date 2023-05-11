namespace Lab5Lib
{
    public class FileWriter : IWriter
    {
        private string _filename;
        public string Filename 
        { 
            get { return _filename; } 
        }

        public FileWriter(string? filename = null)
        {
            _filename = filename ?? Constant.Filename;
        }

        public string? Save(string? message)
        {
            File.WriteAllText(Filename, message);

            return Filename;
        }
    }
}
