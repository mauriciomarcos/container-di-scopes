namespace DependencyInjection.Services.Interfaces;

public interface IServiceTransient
{
    Task<string> DoSometing();
}