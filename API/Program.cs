using Contas_Bancaria.Entidades.Interfaces;
using Contas_Bancaria.Repository.Data;
using Contas_Bancaria.Repository;
using Contas_Bancaria.Service.Interfaces;
using Contas_Bancaria.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InicializadorBD.Inicializar();

builder.Services.AddScoped<IContaCorrente, ContaCorrenteRepository>();
builder.Services.AddScoped<IContaPoupan�a, ContaPoupan�aRepository>();

builder.Services.AddScoped<IContaCorrenteService, ContaCorrenteService>();
builder.Services.AddScoped<IContaPoupan�aService, ContaPoupan�aService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
