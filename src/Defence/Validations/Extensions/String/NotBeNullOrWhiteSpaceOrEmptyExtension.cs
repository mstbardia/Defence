namespace Defence.Validations.Extensions.String;

public static class NotBeNullOrWhiteSpaceOrEmptyExtension
{
    public static StringValidation NotBeNullOrWhiteSpaceOrEmpty(this StringValidation stringValidation)
    {
        stringValidation.Validate(s => !string.IsNullOrWhiteSpace(s), "Must not be null or whitespace or empty",true);

        return stringValidation;
    }
}