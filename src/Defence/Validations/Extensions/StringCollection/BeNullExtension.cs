namespace Defence.Validations.Extensions.StringCollection;

public static class BeNullExtension
{
    public static StringCollectionValidation BeNull(this StringCollectionValidation stringCollectionValidation)
    {
        stringCollectionValidation.Validate(s => s == null , $"Must be null" , true);

        return stringCollectionValidation;
    }
}