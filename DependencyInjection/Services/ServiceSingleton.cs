using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services;

public class ServiceSingleton : IServiceSingleton
{
    private readonly string _guid;

    public ServiceSingleton(ILogger<ServiceSingleton> logger)
    {
        _guid = Guid.NewGuid().ToString();
        logger.LogInformation("Criando a instância no modo SINGLETON!!! - {IdRequisicao}", _guid);       
    }

    public async Task<string> DoSometing() => await Task.FromResult(_guid);
}