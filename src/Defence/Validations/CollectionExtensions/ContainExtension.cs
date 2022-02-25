using Defence.Validations.Abstractions;

namespace Defence.Validations.CollectionExtensions;

public static class ContainExtension
{
    public static BaseValidation<IEnumerable<T>> Contains<T>(this BaseValidation<IEnumerable<T>> validation, T value)
    {
        validation.Validate(inp => inp.Contains(value), $"Must contains {value}");

        return validation;
    }
}