using Microsoft.AspNetCore.Mvc;

namespace mmhttpapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{

    private readonly ILogger<HealthCheckController> _logger;
    private readonly ServerConfiguration _config;

    public HealthCheckController(ILogger<HealthCheckController> logger, ServerConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return _config.Test;
    }
}
