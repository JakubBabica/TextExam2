using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
using Blazor.Services;
using Blazor.Services.Http;
using EfcDataAccess;
using EfcDataAccess.DAOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ITeamDao, TeamEfcDao>();
builder.Services.AddScoped<IPlayerDao, PlayerEfcDao>();
builder.Services.AddScoped<ITeamLogic, TeamLogic>();
builder.Services.AddScoped<ITeamService, TeamClient>();
builder.Services.AddScoped<IPlayerService, PlayerClient>();
builder.Services.AddScoped<IPlayerInterface, PlayerLogic>();
builder.Services.AddScoped(sp=>new HttpClient
    {
        BaseAddress = new Uri("http://localhost:7145")
    
    }
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
