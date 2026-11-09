using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AinTajir.Data;

public class AinTajirDbContextFactory : IDesignTimeDbContextFactory<AinTajirDbContext>
{
    public AinTajirDbContext CreateDbContext(string[] args)
    {
        AinTajirGlobalFeatureConfigurator.Configure();
        AinTajirModuleExtensionConfigurator.Configure();

        AinTajirEfCoreEntityExtensionMappings.Configure();
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AinTajirDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AinTajirDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}