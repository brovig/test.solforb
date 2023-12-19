using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("api/providers")]
[ApiController]
public class ProvidersController : ControllerBase
{
    private readonly IServiceManager _service;

    public ProvidersController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetProviders()
    {
        var providers = await _service.ProviderService.GetProvidersAsync(trackChanges: false);

        return Ok(providers);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProvider(int id)
    {
        var provider = await _service.ProviderService.GetProviderAsync(id, trackChanges: false);

        return Ok(provider);
    }
}
