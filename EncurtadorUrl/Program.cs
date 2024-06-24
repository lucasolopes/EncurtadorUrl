using EncurtadorUrl.Data.Context;
using EncurtadorUrl.Repositories.Implementations;
using EncurtadorUrl.Repositories.Interfaces;
using EncurtadorUrl.Services.Implementations;
using EncurtadorUrl.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EncurtadorContext>(options =>
{
    options.UseInMemoryDatabase("EncurtadorDatabase"); // Nome do banco de dados em memória
});

builder.Services.AddScoped<IEncurtadorService, EncurtadorService>();
builder.Services.AddScoped<IEncurtadorRepository, EncurtadorRepository>();


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
