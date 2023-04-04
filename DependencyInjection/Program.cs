using DependencyInjection.Factories;
using DependencyInjection.FactorySample;
using DependencyInjection.Logic;
using Serilog;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddScoped<ILogicClass, LogicClass>();
        //builder.Services.AddTransient<ISample1, Sample1>();
        //builder.Services.AddSingleton<Func<ISample1>>(x => () => x.GetService<ISample1>()!);
        builder.Services.AddAbstractFactory<ISample1, Sample1>();
        builder.Services.AddAbstractFactory<ISample2, Sample2>();
        builder.Services.AddGenericClassWithDataFactory();
        builder.Services.AddVehicleFactory();

        builder.Host.UseSerilog((Context, config) =>
        {
            config.WriteTo.Console();
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}