using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class BeNullExtension
{
    public static BaseValidation<T?> BeNull<T>(this BaseValidation<T?> validation) where T : struct
    {
        validation.Validate(inp => inp == null, "Must be null",true);

        return validation;
    }
    
    public static BaseValidation<T> BeNull<T>(this BaseValidation<T> validation) where T : class
    {
        validation.Validate(inp => inp == null, "Must be null",true);

        return validation;
    }
}