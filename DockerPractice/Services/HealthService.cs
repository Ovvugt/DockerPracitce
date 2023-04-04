namespace DockerPractice.Services;

public class HealthService : IHealthService
{
    private readonly ILogger<HealthService> _logger;

    public HealthService(ILogger<HealthService> logger)
    {
        _logger = logger;
    }

    public string GetHealth()
    {
        _logger.LogInformation("Health check");
        return "I'm alive!";
    }
}

public interface IHealthService
{
    string GetHealth();
}