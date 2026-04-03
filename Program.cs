var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/verify", () =>
{
    var builderName = "MasonRossi";

    var runner = Environment.GetEnvironmentVariable("RUN_BY") ?? "UNKNOWN";

    var timestamp = DateTime.UtcNow;

    var machineName = Environment.MachineName;

    return Results.Json(new
    {
        builder = builderName,
        runner = runner,
        timestamp = timestamp,
        machineName = machineName
    });
});

app.Run();

