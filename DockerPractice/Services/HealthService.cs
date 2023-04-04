namespace DockerPractice.Services;

public class HealthService : IHealthService
{
    private readonly ILogger _logger;

    public HealthService(ILogger logger)
    {
        _logger = logger;
    }

    public string GetHealth()
    {
        return "I'm alive!";
    }
}

public interface IHealthService
{
    string GetHealth();
}