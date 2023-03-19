using Autofac;
using Autofac.Extensions.DependencyInjection;
using Cygnet.Banking.Api;
using Cygnet.Banking.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider(); // todo
var configuration = provider.GetRequiredService<IConfiguration>();

// Call UseServiceProviderFactory on the Host sub property 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Call ConfigureContainer on the Host sub property 
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new MediatorModule());
});

// Add services to the container.

builder.Services.AddComponents(configuration);
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
