using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstaract;
using Business.Concrete;
using Business.DependencyResolves.Autofac;
using DataAccess.Abstaract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(
    builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();


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
