<h1 align="center">
  <br>
  <a href="https://github.com/mstbardia/Defence">
    <img src="assets/logo/defence.png">
  </a>
  <br>
  LiteBus
  <br>
</h1>

# Defence
ASP.NET Core Validations For HTTP Requests

Defence is a library that helps you to validate your request bounded model by fluent implementations.

### Features
- You can use _**Dependency Injection (DI)**_ . So you can easily do whatever you want for
validating your models before calling Actions. Actually it happens exactly when model bounded by MVC.
For example you can inject your database repository and check some ids.
- It creates chain of violations result per field , so if you set five rules on your field , all
five rules run and Defence collects their result even if one of them failed. (when throw exception is false)
- It uses fluent api so you can put your implementations on where ever you want in your project.
- It is based on the MVC FilterActions so you can use it in architectures like MVC,CQRS.
- **New features are coming...**


### Getting Started

```sh
dotnet add package Defence
dotnet add package Defence.Core
```
### Usage Guide

The following code demonstrates basic usage of Defence.

_Implementation of Defence validator :_
```c#
    public class UserCommandValidator : IDefenceValidator<UserCommand>
    {
        public Task Validate(UserCommand input)
        {                        
            input.Family.Must(nameof(input.Family)).HaveExactLength(5).BeEqual("Hey").NotBeNullOrEmpty();
    
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
If you want Defence throws exceptions :
```c#
    builder.Services.AddDefence(configuration =>
    {
       configuration.ImplementedValidatorTypeKind = typeof(UserCommandValidator);
       configuration.ThrowExceptions = true;
    });
```
Defence result example :
```json
    {
      "defenceErrors": [
        "Family : Must have exact length 5 But it is Null",
        "Family : Must be equal to testi But it is Null",
        "Family : Must not be null or empty",
        "Age : Must be less than 5"
      ],
      "traceId": "0HMF2AHPP1PHI:00000005"
    }
```
