using Inlog.Desafio.Backend.Application.Mappers;
using Inlog.Desafio.Backend.Application.Services;
using Inlog.Desafio.Backend.Domain.Repositories;
using Inlog.Desafio.Backend.Infra.Database;
using Inlog.Desafio.Backend.Infra.Database.Repositories;
using Inlog.Desafio.Backend.WebApi.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(VeiculoVeiculoDTO));

string? connectionString = builder.Configuration.GetConnectionString("Default");
if (string.IsNullOrEmpty(connectionString))
    throw new Exception("Não há connectionString configurada");

builder.Services.AddDbContext<VeiculoContext>(o => o.UseNpgsql(connectionString));

// DI
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowOrigin",
		builder => builder.WithOrigins("http://localhost:4200")
						  .AllowAnyMethod()
						  .AllowAnyHeader());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
