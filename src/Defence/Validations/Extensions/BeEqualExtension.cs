using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class BeEqualExtension
{
    public static BaseValidation<T> BeEqual<T>(this BaseValidation<T> validation, T value) where T : struct  
    {
        validation.Validate(inp => inp.Equals(value), $"Must be equal to {value}");
        
        return validation;
    }
    
    public static BaseValidation<T?> BeEqual<T>(this BaseValidation<T?> validation, T value) where T : struct
    {
        validation.Validate(inp => inp.Equals(value), $"Must be equal to {value}");

        return validation;
    }


    
    #region ReferenceTypes
    
    public static BaseValidation<T> BeEqualOf<T>(this BaseValidation<T> validation, T value) where T : class
    {
        validation.Validate(inp => inp.Equals(value), $"Must be equal to {value}");

        return validation;
    }
    
    public static BaseValidation<string> BeEqual(this BaseValidation<string> validation, string value)
    {
        validation.Validate(s => s == value, $"Must be equal to {value}");

        return validation;
    }
    
    #endregion
}