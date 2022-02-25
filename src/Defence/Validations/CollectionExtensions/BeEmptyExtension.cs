using Defence.Validations.Abstractions;

namespace Defence.Validations.CollectionExtensions;

public static class BeEmptyExtension
{
    public static BaseValidation<IEnumerable<T>> BeEmpty<T>(this BaseValidation<IEnumerable<T>> validation)
    {
        validation.Validate(inp => !inp.Any() , $"Must be Empty");
        
        return validation;
    }
}