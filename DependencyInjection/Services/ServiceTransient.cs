using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services;

public class ServiceTransient : IServiceTransient
{
    private readonly string _guid;

    public ServiceTransient(ILogger<ServiceTransient> logger)
    {
        _guid = Guid.NewGuid().ToString();
        logger.LogInformation("Criando a instância no modo TRANSIENT!!! - {IdRequisicao}", _guid);       
    }

    public async Task<string> DoSometing() => await Task.FromResult(_guid.ToString());
}