using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;

[ApiController]
[Route("api/customer")]
public class CustomerController : ControllerBase
{           
    [HttpGet("get-singleton")]
    public async Task<string> GetSingleton([FromServices] IServiceSingleton _serviceSingleton, [FromServices] IServiceSingleton _serviceSingleton2)
    {
        _ = await _serviceSingleton.DoSometing();
        _ = await _serviceSingleton2.DoSometing();

        return "Ok";
    }    

    [HttpGet("get-scoped")]
    public async Task<string> GetScoped([FromServices] IServiceScoped _serviceScoped, [FromServices] IServiceScoped _serviceScoped2)
    {
        _ = await _serviceScoped.DoSometing();
        _ = await _serviceScoped2.DoSometing();

        return "Ok";
    }

    [HttpGet("get-transient")]
    public async Task<string> GetTransient([FromServices] IServiceTransient _serviceTransiente, [FromServices] IServiceTransient _serviceTransiente2)
    {
        _ = await _serviceTransiente.DoSometing();
        _ = await _serviceTransiente2.DoSometing();

        return "Ok";
    }
}