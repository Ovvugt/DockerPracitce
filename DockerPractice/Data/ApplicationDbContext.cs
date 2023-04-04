using Microsoft.EntityFrameworkCore;

namespace DockerPractice.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) {}
}