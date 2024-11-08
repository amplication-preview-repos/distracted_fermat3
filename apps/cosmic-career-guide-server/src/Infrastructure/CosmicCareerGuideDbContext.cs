using Microsoft.EntityFrameworkCore;

namespace CosmicCareerGuide.Infrastructure;

public class CosmicCareerGuideDbContext : DbContext
{
    public CosmicCareerGuideDbContext(DbContextOptions<CosmicCareerGuideDbContext> options)
        : base(options) { }
}
