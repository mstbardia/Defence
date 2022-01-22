using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using NSubstitute;
using Defence.Core.Exceptions;
using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Internals;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class DefenceIntegerValidationTests
{
    [Fact]
    public async Task Should_throw_with_wrong_input_on_LessThan()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceIntegerValidation(fakeField, 5, defenceErrorHandler);
        
        var result = () => validator.LessThan(5);
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_LessThan()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceIntegerValidation(fakeField, 4, defenceErrorHandler);
        
        var result = () => validator.LessThan(5);

        result.Should().NotThrow();
    }
    
    
}