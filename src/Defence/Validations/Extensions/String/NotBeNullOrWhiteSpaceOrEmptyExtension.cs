using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions.String;

public static class NotBeNullOrWhiteSpaceOrEmptyExtension
{
    public static BaseValidation<string> NotBeNullOrWhiteSpaceOrEmpty(this BaseValidation<string> validation)
    {
        validation.Validate(s => !string.IsNullOrWhiteSpace(s), "Must not be null or whitespace or empty",true);

        return validation;
    }
}