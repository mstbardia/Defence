using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class NotBeNullOrEmptyExtension
{
    public static BaseValidation<string> NotBeNullOrEmpty(this BaseValidation<string> validation)
    {
        validation.Validate(s => !string.IsNullOrEmpty(s), "Must not be null or empty",true);

        return validation;
    }
}