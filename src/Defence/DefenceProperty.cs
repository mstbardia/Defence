namespace Defence;

/// <summary>
/// main class for keeping info from each field on validation
/// </summary>
/// <typeparam name="T"></typeparam>
public class DefenceProperty<T>
{

    public DefenceProperty(string fieldName, T input)
    {
        FieldName = fieldName;
        Input = input;
    }

    public string FieldName { get; set; }
    public T Input { get; set; }
}