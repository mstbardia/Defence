using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class StringCollectionValidation : BaseValidation<IEnumerable<string>>
{
    internal StringCollectionValidation(DefenceProperty<IEnumerable<string>> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}