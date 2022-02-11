namespace Defence.Validations.Extensions.Integer;

public static class NotBeNullExtension
{
    public static NullableIntegerValidation NotBeNull(this NullableIntegerValidation nullableIntegerValidation)
    {
        nullableIntegerValidation.Validate(s => s != null , $"Must not be null" , true);

        return nullableIntegerValidation;
    }
}