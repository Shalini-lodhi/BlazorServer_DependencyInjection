# Dependency Injection (Blazor Server)

[Index.razor]
```c#
@page "/"
@using DependencyInjection.Logic
@inject ILogicClass logic
@inject ILogger<Index> logger

<PageTitle>Index</PageTitle>

<h1>Hello, world!</h1>
<h3>Value1 : @logic.Value1</h3>
<h3>Value1 : @logic.Value2</h3>
@code {
    protected override void OnInitialized()
    {
        logger.LogInformation("Displaying values of {Value1} and {Value2}", logic.Value1, logic.Value2);
    }
}
```
