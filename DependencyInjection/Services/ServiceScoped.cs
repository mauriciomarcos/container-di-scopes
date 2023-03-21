using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services;

public class ServiceScoped : IServiceScoped
{
    private readonly string _guid;

    public ServiceScoped(ILogger<ServiceScoped> logger)
    {
        _guid = Guid.NewGuid().ToString();
        logger.LogInformation("Criando a instância no modo SCOPED!!! - {IdRequisicao}", _guid);        
    }

    public async Task<string> DoSometing() => await Task.FromResult(_guid.ToString());
}