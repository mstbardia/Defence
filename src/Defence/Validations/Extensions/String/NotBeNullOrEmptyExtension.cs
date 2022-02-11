namespace Defence.Validations.Extensions.String;

public static class NotBeNullOrEmptyExtension
{
    public static StringValidation NotBeNullOrEmpty(this StringValidation stringValidation)
    {
        stringValidation.Validate(s => !string.IsNullOrEmpty(s), "Must not be null or empty",true);

        return stringValidation;
    }
}