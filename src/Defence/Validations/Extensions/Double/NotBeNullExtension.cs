namespace Defence.Validations.Extensions.Double;

public static class NotBeNullExtension
{
    public static NullableDoubleValidation NotBeNull(this NullableDoubleValidation nullableDoubleValidation)
    {
        nullableDoubleValidation.Validate(s => s != null , $"Must not be null" , true);

        return nullableDoubleValidation;
    }
}