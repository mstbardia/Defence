namespace Defence.Validations.Extensions.String;

public static class BeNullExtension
{
    public static StringValidation BeNull(this StringValidation stringValidation)
    {
        stringValidation.Validate(s => s == null , $"Must be null" , true);

        return stringValidation;
    }
}