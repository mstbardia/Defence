namespace Defence.Validations.Extensions.Integer;

public static class BeGreaterThanExtension
{
    public static IntegerValidation BeGreaterThan(this IntegerValidation integerValidation, int value)
    {
        integerValidation.Validate(i => i > value, $"Must be greater than {value}");

        return integerValidation;
    }

    public static NullableIntegerValidation BeGreaterThan(this NullableIntegerValidation nullableIntegerValidation, int value)
    {
        nullableIntegerValidation.Validate(i => i > value, $"Must be greater than {value}");

        return nullableIntegerValidation;
    }
    
}