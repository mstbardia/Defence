namespace Defence.Validations.Extensions.String;

public static class HaveExactLengthExtension
{
    public static StringValidation HaveExactLength(this StringValidation stringValidation, int value)
    {
        stringValidation.Validate(s => s.Length == value, $"Must have exact length {value}");

        return stringValidation;
    }
}