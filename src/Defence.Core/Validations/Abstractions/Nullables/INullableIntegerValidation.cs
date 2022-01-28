using Defence.Core.Validations.Abstractions.Nullables.Base;

namespace Defence.Core.Validations.Abstractions.Nullables;

/// <summary>
/// interface which validates fields with integer type
/// </summary>
public interface INullableIntegerValidation : IIntegerValidation , INullValidation<IIntegerValidation>
{
   
}