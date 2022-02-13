namespace Defence.Validations.Extensions.Double;

public static class BeLessThanOrEqualExtension
{
    
    public static DoubleValidation BeLessThanOrEqual(this DoubleValidation doubleValidation, double value)
    {
        doubleValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return doubleValidation;
    }
    
    public static NullableDoubleValidation BeLessThanOrEqual(this NullableDoubleValidation nullableDoubleValidation, double value)
    {
        nullableDoubleValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return nullableDoubleValidation;
    }
}