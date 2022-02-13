namespace Defence.Validations.Extensions.Long;

public static class BeGreaterThanExtension
{
    public static LongValidation BeGreaterThan(this LongValidation longValidation, long value)
    {
        longValidation.Validate(i => i > value, $"Must be greater than {value}");

        return longValidation;
    }

    public static NullableLongValidation BeGreaterThan(this NullableLongValidation nullableLongValidation, long value)
    {
        nullableLongValidation.Validate(i => i > value, $"Must be greater than {value}");

        return nullableLongValidation;
    }
    
}