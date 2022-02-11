using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class IntegerValidation : GenericValidation<int>
{
    internal IntegerValidation(DefenceProperty<int> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}