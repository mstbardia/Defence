namespace Defence.Validations.Extensions.Long;

public static class BeLessThanExtension
{
    public static LongValidation BeLessThan(this LongValidation longValidation, long value)
    {
        longValidation.Validate(i => i < value, $"Must be less than {value}");

        return longValidation;
    }
    
    public static NullableLongValidation BeLessThan(this NullableLongValidation nullableLongValidation, long value)
    {
        nullableLongValidation.Validate(i => i < value, $"Must be less than {value}");

        return nullableLongValidation;
    }

}