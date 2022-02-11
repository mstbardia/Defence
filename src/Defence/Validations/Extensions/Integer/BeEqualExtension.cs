namespace Defence.Validations.Extensions.Integer;

public static class BeEqualExtension
{
    public static IntegerValidation BeEqual(this IntegerValidation integerValidation, int value)
    {
        integerValidation.Validate(i => i == value, $"Must be equal to {value}");

        return integerValidation;
    }
    
    public static NullableIntegerValidation BeEqual(this NullableIntegerValidation nullableIntegerValidation, int value)
    {
        nullableIntegerValidation.Validate(i => i == value, $"Must be equal to {value}");

        return nullableIntegerValidation;
    }
}