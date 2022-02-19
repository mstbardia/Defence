namespace Defence.Validations.Extensions.StringCollection;

public static class NotBeNullExtension
{
    public static StringCollectionValidation NotBeNull(this StringCollectionValidation stringCollectionValidation)
    {
        stringCollectionValidation.Validate(s => s != null , $"Must not be null" , true);

        return stringCollectionValidation;
    }
}