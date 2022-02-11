namespace Defence.Validations.Extensions.String;

public static class HaveLessLengthExtension
{
    public static StringValidation HaveLessLength(this StringValidation stringValidation, int value)
    {
        stringValidation.Validate(s => s.Length < value, $"Must have less length than {value}");

        return stringValidation;
    }
}