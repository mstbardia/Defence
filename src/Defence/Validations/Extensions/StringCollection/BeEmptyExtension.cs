namespace Defence.Validations.Extensions.StringCollection;

public static class BeEmptyExtension
{
    public static StringCollectionValidation BeEmpty(this StringCollectionValidation stringCollectionValidation)
    {
        stringCollectionValidation.Validate(s => !s.Any() , $"Must be Empty");

        return stringCollectionValidation;
    }
}