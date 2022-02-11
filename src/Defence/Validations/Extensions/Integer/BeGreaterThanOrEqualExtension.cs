namespace Defence.Validations.Extensions.Integer;

public static class BeGreaterThanOrEqualExtension
{
    public static IntegerValidation BeGreaterThanOrEqual(this IntegerValidation integerValidation, int value)
    {
        integerValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return integerValidation;
    }
    
    public static NullableIntegerValidation BeGreaterThanOrEqual(this NullableIntegerValidation nullableIntegerValidation, int value)
    {
        nullableIntegerValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return nullableIntegerValidation;
    }
}