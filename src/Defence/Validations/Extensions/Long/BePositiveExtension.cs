namespace Defence.Validations.Extensions.Long;

public static class BePositiveExtension
{
    public static LongValidation BePositive(this LongValidation longValidation)
    {
        longValidation.Validate(i => i >= 0, "Must be positive");

        return longValidation;
    }

    public static NullableLongValidation BePositive(this NullableLongValidation nullableLongValidation)
    {
        nullableLongValidation.Validate(i => i >= 0, "Must be positive");

        return nullableLongValidation;
    }
}