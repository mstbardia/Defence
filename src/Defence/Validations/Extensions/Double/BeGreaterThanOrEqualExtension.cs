namespace Defence.Validations.Extensions.Double;

public static class BeGreaterThanOrEqualExtension
{
    public static DoubleValidation BeGreaterThanOrEqual(this DoubleValidation doubleValidation, double value)
    {
        doubleValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return doubleValidation;
    }
    
    public static NullableDoubleValidation BeGreaterThanOrEqual(this NullableDoubleValidation nullableDoubleValidation, double value)
    {
        nullableDoubleValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return nullableDoubleValidation;
    }
}