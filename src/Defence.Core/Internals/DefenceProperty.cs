namespace Defence.Core.Internals;

/// <summary>
/// main class for keeping info from each field on validation
/// </summary>
/// <typeparam name="T"></typeparam>
internal class DefenceProperty<T>  
{
    protected DefenceProperty(string fieldName , T input)
    {
        FieldName = fieldName;
        Input = input;
    }
    
    protected string FieldName { get; set; }
    protected T Input { get; set; }
}
