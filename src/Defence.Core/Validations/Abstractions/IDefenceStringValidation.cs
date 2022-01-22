namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with string type
/// </summary>
public interface IDefenceStringValidation
{
    IDefenceStringValidation NotBeNullOrWhiteSpaceOrEmpty();
    IDefenceStringValidation BeNullOrWhiteSpaceOrEmpty();
    IDefenceStringValidation NotBeNullOrEmpty();
    IDefenceStringValidation BeNullOrEmpty();
    IDefenceStringValidation BeEqual(string value);
    IDefenceStringValidation HaveExactLength(int value);
    IDefenceStringValidation HaveGreaterLength(int value);
}