using FluentValidation.Results;

namespace Core.Extansions;

public class ValidationErrorDetails : ErrorDetails
{
    public IEnumerable<ValidationFailure> Errors { get; set; }
}