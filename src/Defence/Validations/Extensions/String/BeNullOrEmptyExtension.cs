namespace Defence.Validations.Extensions.String;

public static class BeNullOrEmptyExtension
{
    public static StringValidation BeNullOrEmpty(this StringValidation stringValidation)
    {
        stringValidation.Validate(string.IsNullOrEmpty, "Must be null or empty",true);

        return stringValidation;
    }
}