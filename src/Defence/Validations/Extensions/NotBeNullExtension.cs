using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class NotBeNullExtension
{
    public static BaseValidation<T?> NotBeNull<T>(this BaseValidation<T?> validation) where T : struct, IComparable
    {
        validation.Validate(inp => inp != null, "Must not be null", true);

        return validation;
    }

    public static BaseValidation<T> NotBeNull<T>(this BaseValidation<T> validation) where T : class
    {
        validation.Validate(inp => inp != null, "Must not be null", true);

        return validation;
    }

    public static BaseValidation<string> NotBeNull(this BaseValidation<string> validation)
    {
        validation.Validate(inp => inp != null, $"Must not be null", true);

        return validation;
    }
}