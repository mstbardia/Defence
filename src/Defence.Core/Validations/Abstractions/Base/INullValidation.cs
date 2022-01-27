namespace Defence.Core.Validations.Abstractions.Base;

public interface INullValidation<out T>
{
    /// <summary>
    /// validates that if property is not null
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    T NotBeNull();   
    
    /// <summary>
    /// validates that if property is null
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    T BeNull();   
}
