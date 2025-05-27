using Microsoft.Data.SqlClient;
using System.Data.Common;
using TechVoiture.API.Mappers;
using TechVoiture.BLL.Services;
using TechVoiture.DAL.Repositories;
using TechVoiture.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Mapper
builder.Services.AddAutoMapper(typeof(MapperConfig));

// Add services to the container.
// - BLL
builder.Services.AddScoped<EngineService>();
// - DAL
builder.Services.AddScoped<IEngineRepository, EngineRepository>();
// - DB
builder.Services.AddTransient<DbConnection>((service) =>
{
    return new SqlConnection(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();



app.Run();
