namespace Defence.Validations.Extensions.Double;

public static class BeNegativeExtension
{
    public static DoubleValidation BeNegative(this DoubleValidation doubleValidation)
    {
        doubleValidation.Validate(i => i <= 0, "Must be negative");

        return doubleValidation;
    }
    
    public static NullableDoubleValidation BeNegative(this NullableDoubleValidation nullableDoubleValidation)
    {
        nullableDoubleValidation.Validate(i => i <= 0, "Must be negative");

        return nullableDoubleValidation;
    }
}