using FluentValidation.Results;

namespace EmemIsaac.QuizManager.Application.Common
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            Errors = new List<string>();
            foreach(var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
