using System.Collections.Generic;
using AutoFixture;
using Defence.Exceptions;
using Defence.Internals.Abstractions;
using Defence.Internals.Handlers;
using Defence.Validations.Abstractions;
using Defence.Validations.CollectionExtensions;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class StringCollectionValidationTests
{
    [Theory]
    [InlineData(null)]
    public void Should_throw_with_wrong_input_on_NotBeNull(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be null");
    }

    
    [Theory]
    [InlineData("hi", "hoy")]
    public void Should_not_throw_with_correct_input_on_NotBeNull(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData("hi", "hoy")]
    public void Should_throw_with_wrong_input_on_BeNull(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be null");
    }

    
    [Theory]
    [InlineData(null)]
    public void Should_not_throw_with_correct_input_on_BeNull(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().NotThrow();
    }
 
    
    
    [Theory]
    [InlineData()]
    public void Should_throw_with_wrong_input_on_NotBeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeEmpty();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be empty");
    }

    [Theory]
    [InlineData(null)]
    public void Should_throw_with_null_input_on_NotBeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeEmpty();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be empty But it is Null");
    }
    
    [Theory]
    [InlineData("hi")]
    public void Should_not_throw_with_correct_input_on_NotBeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeEmpty();

        // Assert
        result.Should().NotThrow();
    }
    
    [Theory]
    [InlineData("hey")]
    public void Should_throw_with_wrong_input_on_BeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEmpty();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be empty");
    }

    [Theory]
    [InlineData(null)]
    public void Should_throw_with_null_input_on_BeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEmpty();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be empty But it is Null");
    }
    
    [Theory]
    [InlineData()]
    public void Should_not_throw_with_correct_input_on_BeEmpty(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEmpty();

        // Assert
        result.Should().NotThrow();
    }

    
    [Theory]
    [InlineData("hey","hoy")]
    public void Should_throw_with_wrong_input_on_Contains(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        var containValue = "Bye";
        // Act
        var result = () => validator.Contains(containValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must contains {containValue}");
    }
    [Theory]
    [InlineData(null)]
    public void Should_throw_with_null_input_on_Contains(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);

        var containValue = "Bye";
        // Act
        var result = () => validator.Contains(containValue);
        
        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must contains {containValue} But it is Null");
    }
    
    [Theory]
    [InlineData("hey","hoy")]
    public void Should_not_throw_with_correct_input_on_Contains(params string[] input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<IEnumerable<string>>(new DefenceProperty<IEnumerable<string>>(fakeField,input), defenceErrorHandler);
        
        var containValue = "hey";

        // Act
        var result = () => validator.Contains(containValue);

        // Assert
        result.Should().NotThrow();
    }
}