using Lab2.Interfaces;
using Lab2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();