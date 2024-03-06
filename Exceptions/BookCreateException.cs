namespace idflApp.Exceptions
{
    public class BookCreateException : Exception
    {
        public BookCreateException(): base()
        {
            
        }
        public BookCreateException(string message) : base(message) { }
    }
}
