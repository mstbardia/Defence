namespace Defence.Validations.Extensions.Integer;

public static class BeNegativeExtension
{
    public static IntegerValidation BeNegative(this IntegerValidation integerValidation)
    {
        integerValidation.Validate(i => i <= 0, "Must be negative");

        return integerValidation;
    }
    
    public static NullableIntegerValidation BeNegative(this NullableIntegerValidation nullableIntegerValidation)
    {
        nullableIntegerValidation.Validate(i => i <= 0, "Must be negative");

        return nullableIntegerValidation;
    }
}