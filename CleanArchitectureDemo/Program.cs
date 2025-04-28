using CleanArchitectureDemo.Presentation;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Serilog Configuration
var logger = Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .CreateLogger();

logger.Information("Starting web Api");
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
//register specific services
builder.Services.AddModuleServices(builder.Configuration, logger);



var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();
app.MapControllers();
app.Run();
