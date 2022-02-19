namespace Defence.Validations.Extensions.StringCollection;

public static class ContainExtension
{
    public static StringCollectionValidation Contains(this StringCollectionValidation stringCollectionValidation , string value)
    {
        stringCollectionValidation.Validate(s => s.Contains(value) , $"Must contains {value}");

        return stringCollectionValidation;
    }
}