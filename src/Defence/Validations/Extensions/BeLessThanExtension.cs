using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class BeLessThanExtension
{
    public static BaseValidation<T> BeLessThan<T>(this BaseValidation<T> validation, T value) where T : struct , IComparable
    {
        validation.Validate(inp => inp.CompareTo(value) < 0, $"Must be less than {value}");
        
        return validation;
    }
    
    public static BaseValidation<T?> BeLessThan<T>(this BaseValidation<T?> validation, T value) where T : struct , IComparable
    {
        validation.Validate(inp => inp.Value.CompareTo(value) < 0, $"Must be less than {value}");
        
        return validation;
    }
}