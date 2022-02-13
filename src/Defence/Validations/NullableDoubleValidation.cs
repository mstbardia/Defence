using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class NullableDoubleValidation : GenericValidation<Double?>
{
    internal NullableDoubleValidation(DefenceProperty<Double?> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}