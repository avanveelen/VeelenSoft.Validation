namespace VeelenSoft.Validation.ValidationMessages
{
    public class ValidationMessage
    {
        public ValidationMessage(string id, string message)
        {
            Id = id;
            Message = message;
        }

        public ValidationMessage(string message)
        {
            Message = message;
        }

        public string Id { get; private set; }

        public string Message { get; private set; }
    }
}