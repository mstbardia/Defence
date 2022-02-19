namespace Defence.Validations.Extensions.StringCollection;

public static class NotBeEmptyExtension
{
    public static StringCollectionValidation NotBeEmpty(this StringCollectionValidation stringCollectionValidation)
    {
        stringCollectionValidation.Validate(s => s.Any() , $"Must not be Empty");

        return stringCollectionValidation;
    }
}