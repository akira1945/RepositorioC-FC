
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
object value = builder.Services.AddSwaggerGen();


var app = builder.Build();

//Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
app.UseSwaggerUI();
app.UseSwagger();
}

app.UseHttpsRedirection();

// #region Camada de Apresentação

app.Run();

// #region  Modelo de dados

// #region Camada de dados

// #region Camada de Negocios


