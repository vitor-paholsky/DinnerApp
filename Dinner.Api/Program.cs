using Dinner.Application.Services.Authentication;
using Dinner.Application;
using Dinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication().AddInfrastructure();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
}
