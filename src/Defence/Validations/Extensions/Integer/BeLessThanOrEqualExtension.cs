namespace Defence.Validations.Extensions.Integer;

public static class BeLessThanOrEqualExtension
{
    
    public static IntegerValidation BeLessThanOrEqual(this IntegerValidation integerValidation, int value)
    {
        integerValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return integerValidation;
    }
    
    public static NullableIntegerValidation BeLessThanOrEqual(this NullableIntegerValidation nullableIntegerValidation, int value)
    {
        nullableIntegerValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return nullableIntegerValidation;
    }
}