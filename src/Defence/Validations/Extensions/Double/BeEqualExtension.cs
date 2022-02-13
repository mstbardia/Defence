namespace Defence.Validations.Extensions.Double;

public static class BeEqualExtension
{
    public static DoubleValidation BeEqual(this DoubleValidation doubleValidation, double value)
    {
        doubleValidation.Validate(i => i.CompareTo(value) == 0, $"Must be equal to {value}");

        return doubleValidation;
    }
    
    public static NullableDoubleValidation BeEqual(this NullableDoubleValidation nullableDoubleValidation, double value)
    {
        nullableDoubleValidation.Validate(i => i?.CompareTo(value) == 0, $"Must be equal to {value}");

        return nullableDoubleValidation;
    }
}