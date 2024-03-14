namespace idflApp.Exceptions
{
    public class CreateException : Exception
    {
        public CreateException(): base()
        {
            
        }
        public CreateException(string message) : base(message) { }
    }
}
