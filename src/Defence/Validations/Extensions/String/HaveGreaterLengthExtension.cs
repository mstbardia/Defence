using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class HaveGreaterLengthExtension
{
    public static BaseValidation<string> HaveGreaterLength(this BaseValidation<string> validation, int value)
    {
        validation.Validate(s => s.Length > value, $"Must have greater length than {value}");

        return validation;
    }
}