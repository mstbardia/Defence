namespace Defence.Validations.Extensions.Long;

public static class BeGreaterThanOrEqualExtension
{
    public static LongValidation BeGreaterThanOrEqual(this LongValidation longValidation, long value)
    {
        longValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return longValidation;
    }
    
    public static NullableLongValidation BeGreaterThanOrEqual(this NullableLongValidation nullableLongValidation, long value)
    {
        nullableLongValidation.Validate(i => i >= value, $"Must be greater than or Equal to {value}");

        return nullableLongValidation;
    }
}