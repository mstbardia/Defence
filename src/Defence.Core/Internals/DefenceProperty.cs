namespace Defence.Core.Internals;


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
