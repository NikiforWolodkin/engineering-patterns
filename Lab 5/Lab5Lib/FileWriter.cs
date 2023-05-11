namespace Lab5Lib
{
    public class FileWriter : IWriter
    {
        private string _fileName;
        public string FileName 
        { 
            get { return _fileName; } 
        }

        public FileWriter(string? filename = null)
        {
            _fileName = filename ?? Constant.FileName;
        }

        public string? Save(string? message)
        {
            File.WriteAllText(FileName, message);

            return FileName;
        }
    }
}
