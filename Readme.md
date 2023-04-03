# Dependency Injection (Blazor Server)

## Singleton 
[Program.cs](https://github.com/Shalini-lodhi/BlazorServer_DependencyInjection/edit/2_Adding_DI/DependencyInjection/Program.cs)
```c#
builder.Services.AddSingleton<LogicClass>();
```
[Index.razor](https://github.com/Shalini-lodhi/BlazorServer_DependencyInjection/blob/2_Adding_DI/DependencyInjection/Pages/Index.razor)
```c#
@page "/"
@using DependencyInjection.Logic
@inject LogicClass logic 

<PageTitle>Index</PageTitle>

<h1>Hello, world!</h1>
<h3>Value1 : @logic.Value1</h3>
<h3>Value1 : @logic.Value2</h3>
@code {
    //private LogicClass logic;
    protected override void OnInitialized()
    {
        //intentiating the class 
        //logic = new();
    }
}
```
<img width="684" alt="image" src="https://user-images.githubusercontent.com/55933789/229438356-9719b901-348d-4f9c-ba98-fc4a503b6248.png">

