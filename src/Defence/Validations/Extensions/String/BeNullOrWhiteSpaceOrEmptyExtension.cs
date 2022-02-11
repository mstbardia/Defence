namespace Defence.Validations.Extensions.String;

public static class BeNullOrWhiteSpaceOrEmptyExtension
{
    public static StringValidation BeNullOrWhiteSpaceOrEmpty(this StringValidation stringValidation)
    {
        stringValidation.Validate(string.IsNullOrWhiteSpace, "Must be null or whitespace or empty",true);

        return stringValidation;
    }
}