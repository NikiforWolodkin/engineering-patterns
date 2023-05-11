namespace Lab5Lib
{
    public class Decorator : IWriter
    {
        protected IWriter? _writer;

        public Decorator(IWriter writer)
        {
            _writer = writer;
        }

        public virtual string? Save(string? message)
        {
            return _writer?.Save(message);
        }
    }
}
