# Dependency Injection (Blazor Server)

[Program.cs](https://github.com/Shalini-lodhi/BlazorServer_DependencyInjection/blob/3_Interface_Implementation/DependencyInjection/Program.cs)
```
builder.Services.AddTransient<ILogicClass, SomeOtherLogicClass>();
```
[SomeOtherLogicClass.cs](https://github.com/Shalini-lodhi/BlazorServer_DependencyInjection/blob/3_Interface_Implementation/DependencyInjection/Logic/SomeOtherLogicClass.cs)
```
namespace DependencyInjection.Logic
{
    public class SomeOtherLogicClass : ILogicClass
    {
        public int Value1 { get; private set; }
        public int Value2 { get; private set; }
        public SomeOtherLogicClass()
        {
            Value1 = 235;
            Value2 = 4316;
        }
    }
}
```
