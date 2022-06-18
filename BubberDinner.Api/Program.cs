using BuberDinner.Aplication;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddAplication()
    .AddInfrastructure();

    
    builder.Services.AddControllers();

}



var app = builder.Build();
{

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();

}

