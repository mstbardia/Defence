namespace Defence.Validations.Extensions.Long;

public static class BeEqualExtension
{
    public static LongValidation BeEqual(this LongValidation longValidation, long value)
    {
        longValidation.Validate(i => i.CompareTo(value) == 0, $"Must be equal to {value}");

        return longValidation;
    }
    
    public static NullableLongValidation BeEqual(this NullableLongValidation nullableLongValidation, long value)
    {
        nullableLongValidation.Validate(i => i?.CompareTo(value) == 0, $"Must be equal to {value}");

        return nullableLongValidation;
    }
}