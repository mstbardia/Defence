namespace Defence.Validations.Extensions.String;

public static class BeEqualExtension
{
    public static StringValidation BeEqual(this StringValidation stringValidation, string value)
    {
        stringValidation.Validate(s => s == value, $"Must be equal to {value}");

        return stringValidation;
    }
}