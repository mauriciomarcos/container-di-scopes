namespace DependencyInjection.Services.Interfaces;

public interface IServiceSingleton
{
    Task<string> DoSometing();
}