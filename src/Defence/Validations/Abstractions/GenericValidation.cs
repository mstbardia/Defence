using Defence.Internals.Abstractions;

namespace Defence.Validations.Abstractions;

public abstract class GenericValidation<T>
{
    private readonly DefenceProperty<T> _input;

    private readonly IDefenceErrorHandler _defenceErrorHandler;

    internal GenericValidation(DefenceProperty<T> input, IDefenceErrorHandler defenceErrorHandler)
    {
        _input = input;
        _defenceErrorHandler = defenceErrorHandler;
    }

    public void Validate(Func<T, bool> expression, string error, bool suppressNullCheck = false)
    {
        if (!suppressNullCheck)
            if (IsInputNull(_input.Input, error))
                return;
        
        if (!expression.Invoke(_input.Input))
            _defenceErrorHandler.CreateCurrentRequestError(_input.FieldName, error);
    }

    private bool IsInputNull(T input, string error)
    {
        if (_input.Input != null) return false;

        _defenceErrorHandler.CreateCurrentRequestError(_input.FieldName, error + " But it is Null");

        return true;
    }
}