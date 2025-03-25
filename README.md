# Sushilio.UltimateCalculator

1. Install the Sushilio.UltimateCalcualtor package

`dotnet add package Sushilio.UltimateCalculator`

2. Register the package in your DI container

```csharp
builder.Services.AddSushilioUltimateCalculator();
```

3. Inject `ICalculator` in the constructor of the class you would like to use it in.
