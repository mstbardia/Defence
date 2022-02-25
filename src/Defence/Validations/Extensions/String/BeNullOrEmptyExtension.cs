using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class BeNullOrEmptyExtension
{
    public static BaseValidation<string> BeNullOrEmpty(this BaseValidation<string> validation)
    {
        validation.Validate(string.IsNullOrEmpty, "Must be null or empty",true);

        return validation;
    }
}