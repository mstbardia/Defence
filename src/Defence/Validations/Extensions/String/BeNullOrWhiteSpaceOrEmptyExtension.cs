using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class BeNullOrWhiteSpaceOrEmptyExtension
{
    public static BaseValidation<string> BeNullOrWhiteSpaceOrEmpty(this BaseValidation<string> validation)
    {
        validation.Validate(string.IsNullOrWhiteSpace, "Must be null or whitespace or empty",true);

        return validation;
    }
}