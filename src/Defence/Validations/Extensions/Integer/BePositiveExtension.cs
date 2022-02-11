namespace Defence.Validations.Extensions.Integer;

public static class BePositiveExtension
{
    public static IntegerValidation BePositive(this IntegerValidation integerValidation)
    {
        integerValidation.Validate(i => i >= 0, "Must be positive");

        return integerValidation;
    }

    public static NullableIntegerValidation BePositive(this NullableIntegerValidation nullableIntegerValidation)
    {
        nullableIntegerValidation.Validate(i => i >= 0, "Must be positive");

        return nullableIntegerValidation;
    }
}