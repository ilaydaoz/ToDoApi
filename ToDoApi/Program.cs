using FluentValidation.AspNetCore;
using Serilog;
using ToDoBusiness.Validation;
using ToDoCore.Middlewares;
using ToDoDataAccess;
using ToDoListBusiness;

var builder = WebApplication.CreateBuilder(args);
var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .WriteTo.Console()
  .WriteTo.Debug(Serilog.Events.LogEventLevel.Information)
  .WriteTo.File("logs/log.txt")
  .Enrich.FromLogContext()

  .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

// Add services to the container.

builder.Services.AddControllers()
      .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<ToDoPriorityValidation>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataAccessServices(builder.Configuration);
builder.Services.AddBusinessServices();

var app = builder.Build();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
