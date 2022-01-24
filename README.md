# Defence
ASP.NET Core Validations For Request Bounded Model

Defence is a library that helps you to validate your request bounded model by fluent implementations.

_**Pros :**_
- You can use _**Dependency Injection (DI)**_ . So you can easily do whatever you want for
validating your models before calling Actions. Actually it happens exactly when model bounded by MVC.
For example you can inject your database repository and check some ids.
- It uses fluent design so you can put your implementations on where ever you want in your project.
- It is based on the MVC FilterActions so you can use it in architectures like MVC,CQRS.
- **New features are coming...**


### Getting Started

```sh
dotnet add package Defence
dotnet add package Defence.Core
```
### Basic usage

The following code demonstrates basic usage of Defence.

_Implementation of Defence validator :_
```c#
    public class UserCommandValidator : IDefenceValidator<UserCommand>
    {
        public Task Validate(UserCommand input)
        {
            
            input.Family.Must(nameof(input.Family)).NotBeNullOrEmpty();
            
            input.Family.Must(nameof(input.Family)).HaveExactLength(5);
    
            input.Age.Must(nameof(input.Age)).LessThan(2);
            
            return Task.CompletedTask;
        }
    }
```

_Setting Up Defence in Program.cs on Net 6 :_
```c#
    var builder = WebApplication.CreateBuilder(args);
    
    builder.Services.AddDefence(configuration =>
    {
       configuration.ImplementedValidatorTypeKind = typeof(UserCommandValidator);
    });
```
Methods exist for validation on primitives :

String :
```c#
-NotBeNullOrWhiteSpaceOrEmpty();
-BeNullOrWhiteSpaceOrEmpty();
-NotBeNullOrEmpty();
-BeNullOrEmpty();
-BeEqual(string value);
-HaveExactLength(int value);
-HaveGreaterLength(int value);
```