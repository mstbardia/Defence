using Defence.Internals.Abstractions;
using Defence.Validations.Abstractions;

namespace Defence.Validations;

public class StringValidation : GenericValidation<string>
{
    internal StringValidation(DefenceProperty<string> property, IDefenceErrorHandler defenceErrorHandler) : base(property, defenceErrorHandler)
    {
        
    }
}