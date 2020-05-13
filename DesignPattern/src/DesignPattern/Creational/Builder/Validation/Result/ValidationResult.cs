namespace DesignPattern.Creational.Builder.Validation.Result
{
    public class ValidationResult
    {
        public ValidationResult(bool success = true, string message = null)
        {
            Message = message;
            Success = success;
        }

        public string Message { get; private set; }
        public bool Success { get; private set; }

        public static ValidationResult GetSuccess() => new ValidationResult();

        public static ValidationResult GetFailure(string errorMessage) => new ValidationResult(false, errorMessage);
    }
}
