using Defence.Validations.Abstractions;

namespace Defence.Validations.CollectionExtensions;

public static class NotBeNullExtension
{
    public static BaseValidation<IEnumerable<T>> NotBeNull<T>(this BaseValidation<IEnumerable<T>> validation)
    {
        validation.Validate(inp => inp != null, $"Must not be null", true);

        return validation;
    }
}