using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class HaveExactLengthExtension
{
    public static BaseValidation<string> HaveExactLength(this BaseValidation<string> validation, int value)
    {
        validation.Validate(s => s.Length == value, $"Must have exact length {value}");

        return validation;
    }
}