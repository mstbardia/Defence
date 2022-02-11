namespace Defence.Validations.Extensions.Integer;

public static class BeNullExtension
{
    public static NullableIntegerValidation BeNull(this NullableIntegerValidation nullableIntegerValidation)
    {
        nullableIntegerValidation.Validate(s => s == null , $"Must be null" , true);

        return nullableIntegerValidation;
    }
}