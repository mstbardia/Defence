using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class NullableLongValidation : BaseValidation<long?>
{
    internal NullableLongValidation(DefenceProperty<long?> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}