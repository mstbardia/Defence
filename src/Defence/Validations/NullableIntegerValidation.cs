using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class NullableIntegerValidation : GenericValidation<int?>
{
    internal NullableIntegerValidation(DefenceProperty<int?> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}