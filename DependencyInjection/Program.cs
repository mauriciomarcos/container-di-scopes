using DependencyInjection.Services.Interfaces;
using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IServiceSingleton, ServiceSingleton>();
builder.Services.AddTransient<IServiceTransient, ServiceTransient>();
builder.Services.AddScoped<IServiceScoped, ServiceScoped>();


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