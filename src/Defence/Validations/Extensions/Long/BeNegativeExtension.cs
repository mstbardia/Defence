namespace Defence.Validations.Extensions.Long;

public static class BeNegativeExtension
{
    public static LongValidation BeNegative(this LongValidation longValidation)
    {
        longValidation.Validate(i => i <= 0, "Must be negative");

        return longValidation;
    }
    
    public static NullableLongValidation BeNegative(this NullableLongValidation nullableLongValidation)
    {
        nullableLongValidation.Validate(i => i <= 0, "Must be negative");

        return nullableLongValidation;
    }
}