namespace Defence.Validations.Extensions.Double;

public static class BePositiveExtension
{
    public static DoubleValidation BePositive(this DoubleValidation doubleValidation)
    {
        doubleValidation.Validate(i => i >= 0, "Must be positive");

        return doubleValidation;
    }

    public static NullableDoubleValidation BePositive(this NullableDoubleValidation nullableDoubleValidation)
    {
        nullableDoubleValidation.Validate(i => i >= 0, "Must be positive");

        return nullableDoubleValidation;
    }
}