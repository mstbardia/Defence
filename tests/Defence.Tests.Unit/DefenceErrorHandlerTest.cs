using System.Threading.Tasks;
using AutoFixture;
using Defence.Core;
using FluentAssertions;
using NSubstitute;
using Defence.Core.Exceptions;
using Defence.Core.Handlers.Internals;
using Defence.Core.Handlers.Internals.Abstractions;
using Xunit;

namespace Defence.Tests.Unit;

public class DefenceErrorHandlerTest
{

    [Fact]
    public async Task Should_return_correct_error_for_specific_request()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        
        //req #1
        var firstRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f1","e1");
        
        //req #2
        var secondRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(secondRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f2","e2");
        
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = defenceErrorHandler.GetCurrentRequestResult();

        // Assert
        result.DefenceErrors.Should().BeEquivalentTo(new[] { "f1 : e1"});
        result.TraceId.Should().Be(firstRequestTraceId);
    }

    
    [Fact]
    public async Task Should_return_all_errors_for_specific_request()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        //req #1
        var firstRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f1","e1");
        defenceErrorHandler.CreateCurrentRequestError("f2","e2");
        defenceErrorHandler.CreateCurrentRequestError("f3","e3");
        //req #2
        var secondRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(secondRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f4","e4");
        
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = defenceErrorHandler.GetCurrentRequestResult();

        // Assert
        result.DefenceErrors.Should().BeEquivalentTo(new[] { "f1 : e1" , "f2 : e2", "f3 : e3" });
        result.TraceId.Should().Be(firstRequestTraceId);
    }
    
      
    [Fact]
    public async Task Should_return_empty_list_for_specific_request_when_no_error_exist()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var firstRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = defenceErrorHandler.GetCurrentRequestResult();

        // Assert
        result.Should().BeNull();
    }
    
    [Fact]
    public async Task Should_not_create_duplicate_errors_for_specific_request()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var firstRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        
        // Act
        defenceErrorHandler.CreateCurrentRequestError("f1","e1");
        defenceErrorHandler.CreateCurrentRequestError("f2","e2");
        defenceErrorHandler.CreateCurrentRequestError("f2","e2");
        defenceErrorHandler.CreateCurrentRequestError("f3","e3");

        
        // Assert
        var result = defenceErrorHandler.GetCurrentRequestResult();
        result.DefenceErrors.Should().BeEquivalentTo(new[] { "f1 : e1" , "f2 : e2", "f3 : e3" });
        result.TraceId.Should().Be(firstRequestTraceId);
    }
    
    
    [Fact]
    public async Task Should_clear_errors_correctly_for_specific_request()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        //req #1
        var firstRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f1","e1");
        defenceErrorHandler.CreateCurrentRequestError("f2","e2");
        defenceErrorHandler.CreateCurrentRequestError("f3","e3");
        //req #2
        var secondRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(secondRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f4","e4");
        
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        defenceErrorHandler.ClearCurrentRequestErrors();

        // Assert
        var result = defenceErrorHandler.GetCurrentRequestResult();
        result.Should().BeNull();
    }
    
    
    [Fact]
    public async Task Should_not_throw_at_clear_errors_for_specific_request_with_no_errors()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        //req #1
        var firstRequestTraceId = new Fixture().Create<string>();
        //req #2
        var secondRequestTraceId = new Fixture().Create<string>();
        defenceContextHandler.GetRequestTraceId().Returns(secondRequestTraceId);
        defenceErrorHandler.CreateCurrentRequestError("f4","e4");
        
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = () =>  defenceErrorHandler.ClearCurrentRequestErrors();

        // Assert
        result.Should().NotThrow();
    }
    
    
    
    [Fact]
    public async Task Should_throw_when_throw_options_true_for_specific_request()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var firstRequestTraceId = new Fixture().Create<string>();
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = () =>  defenceErrorHandler.CreateCurrentRequestError("f1","e1");


        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }

    
    [Fact]
    public async Task Should_clear_request_errors_when_throw_errors()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var firstRequestTraceId = new Fixture().Create<string>();
        
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        defenceContextHandler.GetRequestTraceId().Returns(firstRequestTraceId);

        // Act
        var result = () =>  defenceErrorHandler.CreateCurrentRequestError("f1","e1");


        // Assert
        var checkErrorsExist = defenceErrorHandler.GetCurrentRequestResult();
        result.Should().ThrowExactly<DefenceBadRequestException>();
        checkErrorsExist.Should().BeNull();
    }
    
    
}