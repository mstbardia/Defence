namespace Defence.Validations.Extensions.Long;

public static class NotBeNullExtension
{
    public static NullableLongValidation NotBeNull(this NullableLongValidation nullableLongValidation)
    {
        nullableLongValidation.Validate(s => s != null , $"Must not be null" , true);

        return nullableLongValidation;
    }
}