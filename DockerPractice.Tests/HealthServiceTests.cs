using DockerPractice.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace DockerPractice.Tests;

[TestClass]
public class HealthServiceTests
{
    [TestMethod]
    public void GetHealthReturnsImAlive()
    {
        const string expectedResult = "I'm alive!";
        var logger = new Mock<ILogger<HealthService>>();
        var healthService = new HealthService(logger.Object);
        
        var result = healthService.GetHealth();
        
        Assert.AreEqual(expectedResult, result);
    }
}