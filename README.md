<h1 align="center">
  <br>
  <a href="https://github.com/mstbardia/Defence">
    <img src="assets/logo/defence.png">
  </a>
  <br>
  Defence
  <br>
</h1>

ASP.NET Core Model Validation For HTTP Requests.

Defence is a library that helps you to validate your request input model which is made
by model binding.

<p align="left">       
  <a href="https://github.com/mstbardia/Defence/actions/workflows/publish-package.yml">
    <img src="https://github.com/mstbardia/Defence/actions/workflows/publish-packages.yml/badge.svg?branch=main">
  </a>
  <a href="https://www.nuget.org/packages/Defence">
    <img src="https://img.shields.io/nuget/v/Defence?style=plastic">
  </a>
</p>

### Overview
- You can use _**Dependency Injection (DI)**_ . So you can easily do whatever you want for
validating your models before calling Actions. Actually it happens exactly when model bounded by MVC.
For example you can inject your database repository and check some ids.
- It creates chain of violations result per field , so if you set five rules on your field , all
five rules run and Defence collects their result even if one of them failed. (when throw exception is false)
- It uses fluent api so you can put your implementations on where ever you want in your project.
- It is based on the MVC FilterAction feature so you can use it in architectures like MVC,CQRS.
- Based on Net 6.
- **New features are coming...**


### Getting Started

```sh
dotnet add package Defence
```
### Usage Guide

The following code demonstrates basic usage of Defence.

_Implementation of Defence validator :_
```c#
    public class UserCommandValidator : IDefenceValidator<UserCommand>
    {
        public Task Validate(UserCommand input)
        {                        
            input.BoolExample.Must(nameof(input.BoolExample)).BeEqual(true);
            input.ByteExample.Must(nameof(input.ByteExample)).BeGreaterThan((byte)1);
            input.CharExample.Must(nameof(input.CharExample)).BeEqual('x');
            input.LongExample.Must(nameof(input.LongExample)).BePositive();
            input.ShortExample.Must(nameof(input.ShortExample)).BeNegative();
            input.UshortExample.Must(nameof(input.UshortExample)).BeEqual((ushort)2);
            input.SByteExample.Must(nameof(input.SByteExample)).BeEqual((sbyte)1);
            
            input.NIntExample.Must(nameof(input.NIntExample)).BeLessThan(1);
            input.NLongExample.Must(nameof(input.NLongExample)).BePositive();
            input.NShortExample.Must(nameof(input.NShortExample)).BeNegative();
            input.NuShortExample.Must(nameof(input.NuShortExample)).BeEqual((ushort)2);
            input.NsByteExample.Must(nameof(input.NsByteExample)).BeEqual((sbyte)1);
            input.StringCollectionExample.Must(nameof(input.StringCollectionExample)).NotBeEmpty();

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
        "BoolExample : Must be equal to True",
        "ByteExample : Must be greater than 1",
        "CharExample : Must be equal to x",
        "DoubleExample : Must be greater than 3.3",
        "FloatExample : Must be equal to 4",
        "UshortExample : Must be equal to 2",
        "SByteExample : Must be equal to 1",
        "NIntExample : Must be less than 1 But it is Null",
        "NLongExample : Must be positive But it is Null",
        "NShortExample : Must be negative But it is Null",
        "NuShortExample : Must be equal to 2 But it is Null",
        "NsByteExample : Must be equal to 1 But it is Null"
      ],
      "traceId": "0HMFOJOP0A1I9:00000005"
    } 
```
