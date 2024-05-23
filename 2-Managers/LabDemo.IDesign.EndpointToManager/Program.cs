using LabDemo.IDesign.Accessors;
using LabDemo.IDesign.EntryManager.Models;
using System.Net;

// this will read ASPNETCORE_ENVIRONMENT for the hosting environmnet, but DOTNET_ENVIRONMENT, if set, will override this
var builder = WebApplication.CreateBuilder(args);

// Add configuration sources
// For development and local use (when running in debugging) use launchsettings.json
// unless it's a secret; then we add the secret to the local users file for local development
// TODO: setup deploy environments with secrets

builder.Configuration.AddEnvironmentVariables();

//builder.Configuration.AddUserSecrets(); // for connection strings

// Add services to the container.

var accessorConfiguration = builder.Configuration.GetSection("Accessor");
builder.Services.ConfigureAccessorService(accessorConfiguration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/ping", () => {
    Results.Ok<string>("hello");
})
.Produces<string>();

// TODO: for development purposes only; remove after flow complete
var _temporaryLabs = new List<UserLab>()
{
    new() { Name = "Glucose", Measurement = 98, UnitsOfMeasure = "mg/dL" }
};


app.MapGet("/", () => {
    return new LabworkForUser() { Labs = _temporaryLabs }; 
})
.WithName("GetLabwork")
.WithOpenApi();

app.Run();

public partial class Program { }
