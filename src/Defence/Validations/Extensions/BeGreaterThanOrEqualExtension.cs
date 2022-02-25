﻿using Defence.Validations.Abstractions;

namespace Defence.Validations.Extensions;

public static class BeGreaterThanOrEqualExtension
{
    public static BaseValidation<T> BeGreaterThanOrEqual<T>(this BaseValidation<T> validation, T value) where T : struct , IComparable
    {
        validation.Validate(inp => inp.CompareTo(value) >= 0, $"Must be greater than or Equal to {value}");
        
        return validation;
    }
    
    public static BaseValidation<T?> BeGreaterThanOrEqual<T>(this BaseValidation<T?> validation, T value) where T : struct , IComparable
    {
        validation.Validate(inp => inp.Value.CompareTo(value) >= 0, $"Must be greater than or Equal to {value}");
        
        return validation;
    }
}