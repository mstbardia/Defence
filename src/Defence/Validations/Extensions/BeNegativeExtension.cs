using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class BeNegativeExtension
{
    public static BaseValidation<T> BeNegative<T>(this BaseValidation<T> validation) where T : struct, IComparable
    {
        T builtInTypeZero = default;

        validation.Validate(inp => inp.CompareTo(builtInTypeZero) <= 0, "Must be negative");
        
        return validation;
    }

    public static BaseValidation<T?> BeNegative<T>(this BaseValidation<T?> validation) where T : struct, IComparable
    {
        T builtInTypeZero = default;

        validation.Validate(inp => inp.Value.CompareTo(builtInTypeZero) <= 0, "Must be negative");

        return validation;
    }
}