using AutoFixture;
using Defence.Exceptions;
using Defence.Internals.Abstractions;
using Defence.Internals.Handlers;
using Defence.Validations.Abstractions;
using Defence.Validations.Extensions;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class IntegerValidationTests
{
    [Theory]
    [InlineData(5, 5), InlineData(6, 5)]
    public void Should_throw_with_wrong_input_on_BeLessThan(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than {expectedValue}");
    }

    [Theory]
    [InlineData(4, 5)]
    public void Should_not_throw_with_correct_input_on_BeLessThan(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThan(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(6, 5)]
    public void Should_throw_with_wrong_input_on_BeLessThanOrEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than or Equal to {expectedValue}");
    }

    [Theory]
    [InlineData(5, 5), InlineData(4, 5)]
    public void Should_not_throw_with_correct_input_on_BeLessThanOrEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThanOrEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(5, 5), InlineData(4, 5)]
    public void Should_throw_with_wrong_input_on_BeGreaterThan(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than {expectedValue}");
    }
    
    [Theory]
    [InlineData(6, 5)]
    public void Should_not_throw_with_correct_input_on_BeGreaterThan(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThan(expectedValue);

        // Assert
        result.Should().NotThrow();
    }

    [Theory]
    [InlineData(4, 5)]
    public void Should_throw_with_wrong_input_on_BeGreaterThanOrEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than or Equal to {expectedValue}");
    }
    
    [Theory]
    [InlineData(5, 5), InlineData(6, 5)]
    public void Should_not_throw_with_correct_input_on_BeGreaterThanOrEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThanOrEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }
    
    [Theory]
    [InlineData(4, 5),InlineData(6, 5)]
    public void Should_throw_with_wrong_input_on_BeEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be equal to {expectedValue}");
    }
    
    [Theory]
    [InlineData(5, 5)]
    public void Should_not_throw_with_correct_input_on_BeEqual(int input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }
    
    
    [Theory]
    [InlineData(-1)]
    public void Should_throw_with_wrong_input_on_BePositive(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BePositive();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be positive");
    }
    
    [Theory]
    [InlineData(5),InlineData(0)]
    public void Should_not_throw_with_correct_input_on_BePositive(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BePositive();

        // Assert
        result.Should().NotThrow();
    }
    
    
    [Theory]
    [InlineData(1)]
    public void Should_throw_with_wrong_input_on_BeNegative(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNegative();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be negative");
    }
    
    [Theory]
    [InlineData(-5),InlineData(0)]
    public void Should_not_throw_with_correct_input_on_BeNegative(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new BaseValidation<int>(new DefenceProperty<int>(fakeField,input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNegative();

        // Assert
        result.Should().NotThrow();
    }
}