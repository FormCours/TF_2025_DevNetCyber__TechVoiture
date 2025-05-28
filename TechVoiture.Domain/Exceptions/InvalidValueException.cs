namespace TechVoiture.Domain.Exceptions
{
    public class InvalidValueException : DomainException
    {
        public string FieldName { get; init; }

        public InvalidValueException(string field ,string message)
            : base(message)
        {
            FieldName = field;
        }
    }
}
