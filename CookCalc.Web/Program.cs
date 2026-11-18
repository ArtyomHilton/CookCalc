var logger = LoggerFactory
    .Create(cfg =>
    {
        cfg.AddConsole();
    })
    .CreateLogger<Program>();

try
{
    logger.LogInformation("Server starting");

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddOpenApi();

    var app = builder.Build();
    
    app.MapOpenApi();

    await app.RunAsync();

}
catch (Exception exception)
{
    logger.LogCritical(exception, "Server start failed");
}
finally
{
    logger.LogInformation("Server stopped");
}