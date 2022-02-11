namespace Defence.Validations.Extensions.Integer;

public static class BeLessThanExtension
{
    public static IntegerValidation BeLessThan(this IntegerValidation integerValidation, int value)
    {
        integerValidation.Validate(i => i < value, $"Must be less than {value}");

        return integerValidation;
    }
    
    public static NullableIntegerValidation BeLessThan(this NullableIntegerValidation nullableIntegerValidation, int value)
    {
        nullableIntegerValidation.Validate(i => i < value, $"Must be less than {value}");

        return nullableIntegerValidation;
    }

}