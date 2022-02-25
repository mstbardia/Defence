using Defence.Validations.Abstractions;

namespace Defence.Validations.CollectionExtensions;

public static class BeNullExtension
{
    public static BaseValidation<IEnumerable<T>> BeNull<T>(this BaseValidation<IEnumerable<T>> validation)
    {
        validation.Validate(inp => inp == null , $"Must be null",true);

        return validation;
    }
}