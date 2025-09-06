using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using persistence;
using System.Diagnostics;

var builder = Host.CreateDefaultBuilder();

builder.ConfigureAppConfiguration(options =>
{
    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == null)
    {
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
    }

    options.AddJsonFile("appsettings.json");
    options.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json");
    options.AddEnvironmentVariables();
});

builder.ConfigureServices((ctx, s) =>
{
    Setup.AddPostgres(s, ctx.Configuration);
});

var app = builder.Build();

using var activitySource = new ActivitySource("Migrator");
using var activity = activitySource.StartActivity("Setup");

var stopwatch = Stopwatch.StartNew();

await Setup.SeedPostgresAsync(app.Services);

stopwatch.Stop();

Console.WriteLine($"Setup finished. Time taken = {stopwatch.ElapsedMilliseconds} miliseconds");

Environment.Exit(0);