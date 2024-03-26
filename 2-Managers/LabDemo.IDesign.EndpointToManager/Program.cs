using LabDemo.IDesign.EndpointToManager.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
