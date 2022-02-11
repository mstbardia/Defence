using Defence.Abstractions;
using Defence.Validations.Extensions.Integer;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        
        
        input.DD.Must("DD").BeGreaterThan(3).BeLessThan(5);
          
        return Task.CompletedTask;
         
        
    }
}