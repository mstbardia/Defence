namespace Defence.Validations.Extensions.Double;

public static class BeGreaterThanExtension
{
    public static DoubleValidation BeGreaterThan(this DoubleValidation doubleValidation, double value)
    {
        doubleValidation.Validate(i => i > value, $"Must be greater than {value}");

        return doubleValidation;
    }

    public static NullableDoubleValidation BeGreaterThan(this NullableDoubleValidation nullableDoubleValidation, double value)
    {
        nullableDoubleValidation.Validate(i => i > value, $"Must be greater than {value}");

        return nullableDoubleValidation;
    }
    
}