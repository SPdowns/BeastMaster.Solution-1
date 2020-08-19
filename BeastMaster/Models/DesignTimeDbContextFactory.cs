using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BeastMaster.Models
{
  public class BeastMasterContextFactory : IDesignTimeDbContextFactory<BeastMasterContext>
  {

    BeastMasterContext IDesignTimeDbContextFactory<BeastMasterContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BeastMasterContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BeastMasterContext(builder.Options);
    }
  }
}