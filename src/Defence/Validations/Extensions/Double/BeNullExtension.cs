namespace Defence.Validations.Extensions.Double;

public static class BeNullExtension
{
    public static NullableDoubleValidation BeNull(this NullableDoubleValidation nullableDoubleValidation)
    {
        nullableDoubleValidation.Validate(s => s == null , $"Must be null" , true);

        return nullableDoubleValidation;
    }
}