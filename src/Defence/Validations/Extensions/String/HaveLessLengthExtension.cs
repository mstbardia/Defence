using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class HaveLessLengthExtension
{
    public static BaseValidation<string> HaveLessLength(this BaseValidation<string> validation, int value)
    {
        validation.Validate(s => s.Length < value, $"Must have less length than {value}");

        return validation;
    }
}