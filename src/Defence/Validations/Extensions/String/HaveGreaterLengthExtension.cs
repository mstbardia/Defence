namespace Defence.Validations.Extensions.String;

public static class HaveGreaterLengthExtension
{
    public static StringValidation HaveGreaterLength(this StringValidation stringValidation, int value)
    {
        stringValidation.Validate(s => s.Length > value, $"Must have greater length than {value}");

        return stringValidation;
    }
}