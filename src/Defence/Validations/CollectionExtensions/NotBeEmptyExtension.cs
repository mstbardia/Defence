using Defence.Validations.Abstractions;

namespace Defence.Validations.CollectionExtensions;

public static class NotBeEmptyExtension
{
    public static BaseValidation<IEnumerable<T>> NotBeEmpty<T>(this BaseValidation<IEnumerable<T>> validation)
    {
        validation.Validate(inp => inp.Any() , $"Must not be Empty");

        return validation;
    }
}