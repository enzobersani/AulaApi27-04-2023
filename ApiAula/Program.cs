using ApiAula.Interfaces;
using ApiAula.Services;
using Microsoft.OpenApi.Models;
using SimpleInjector;

var builder = WebApplication.CreateBuilder(args);
var container = new Container();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "WebAPI.Application",
        Version = "v1",
    });
});

builder.Services.AddSimpleInjector(container, options =>
{
    options.AddAspNetCore().AddControllerActivation();
});

container.Register<IProdutoServico, ProdutoService>(Lifestyle.Scoped);

var app = builder.Build();

app.Services.UseSimpleInjector(container);
container.Verify();

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