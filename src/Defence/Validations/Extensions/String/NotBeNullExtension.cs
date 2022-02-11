namespace Defence.Validations.Extensions.String;

public static class NotBeNullExtension
{
    public static StringValidation NotBeNull(this StringValidation stringValidation)
    {
        stringValidation.Validate(s => s != null , $"Must not be null" , true);

        return stringValidation;
    }
}