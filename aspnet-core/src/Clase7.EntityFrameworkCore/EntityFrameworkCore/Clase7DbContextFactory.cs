using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Clase7.Configuration;
using Clase7.Web;

namespace Clase7.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Clase7DbContextFactory : IDesignTimeDbContextFactory<Clase7DbContext>
    {
        public Clase7DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Clase7DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Clase7DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Clase7Consts.ConnectionStringName));

            return new Clase7DbContext(builder.Options);
        }
    }
}
