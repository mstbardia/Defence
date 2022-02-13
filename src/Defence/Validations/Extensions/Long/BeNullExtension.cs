namespace Defence.Validations.Extensions.Long;

public static class BeNullExtension
{
    public static NullableLongValidation BeNull(this NullableLongValidation nullableLongValidation)
    {
        nullableLongValidation.Validate(s => s == null , $"Must be null" , true);

        return nullableLongValidation;
    }
}