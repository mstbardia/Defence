namespace Defence.Validations.Extensions.Long;

public static class BeLessThanOrEqualExtension
{
    
    public static LongValidation BeLessThanOrEqual(this LongValidation longValidation, long value)
    {
        longValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return longValidation;
    }
    
    public static NullableLongValidation BeLessThanOrEqual(this NullableLongValidation nullableLongValidation, long value)
    {
        nullableLongValidation.Validate(i => i <= value, $"Must be less than or Equal to {value}");

        return nullableLongValidation;
    }
}