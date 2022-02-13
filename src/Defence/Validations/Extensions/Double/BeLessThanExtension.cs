namespace Defence.Validations.Extensions.Double;

public static class BeLessThanExtension
{
    public static DoubleValidation BeLessThan(this DoubleValidation doubleValidation, double value)
    {
        doubleValidation.Validate(i => i < value, $"Must be less than {value}");

        return doubleValidation;
    }
    
    public static NullableDoubleValidation BeLessThan(this NullableDoubleValidation nullableDoubleValidation, double value)
    {
        nullableDoubleValidation.Validate(i => i < value, $"Must be less than {value}");

        return nullableDoubleValidation;
    }

}