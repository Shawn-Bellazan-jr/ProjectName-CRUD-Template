using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ProjectName.Application.Interfaces;
using ProjectName.Application.Interfaces.IRepositories;
using ProjectName.Application.Interfaces.IServices;
using ProjectName.Application.Services;
using ProjectName.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.


// Repositories and Unit of Work
// Register Unit of Work and Generic Repositories
builder.Services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));  // Register UnitOfWork for DI
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericService<>));  // Generic Repository
builder.Services.AddScoped(typeof(IService<>), typeof(GenericService<>));  // Generic Service

// Controllers and Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "ProjectName.Api", Version = "v1" });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AspireApp API v1");
        c.RoutePrefix = string.Empty;  // Set Swagger UI to appear at the root
    });
}
app.MapControllers();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
