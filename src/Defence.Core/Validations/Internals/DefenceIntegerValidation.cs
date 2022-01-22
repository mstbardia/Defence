using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;

namespace Defence.Core.Validations.Internals;

internal class DefenceIntegerValidation : DefenceProperty<int>, IDefenceIntegerValidation
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;
    
    public DefenceIntegerValidation(string fieldName, int input , IDefenceErrorHandler defenceErrorHandler) : base(fieldName, input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }
    
    public IDefenceIntegerValidation LessThan(int value)
    {
        if (Input >= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be less than {value}");

        return this;
    }
}