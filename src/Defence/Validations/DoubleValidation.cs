using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class DoubleValidation : GenericValidation<double>
{
    internal DoubleValidation(DefenceProperty<double> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}