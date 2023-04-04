using DockerPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;
        private readonly ILogger<HealthController> _logger;

        public HealthController(IHealthService healthService, ILogger<HealthController> logger)
        {
            _healthService = healthService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Health check");
            return Ok(_healthService.GetHealth());
        }
    }
}