namespace DependencyInjection.Services.Interfaces;

public interface IServiceScoped
{
    Task<string> DoSometing();
}