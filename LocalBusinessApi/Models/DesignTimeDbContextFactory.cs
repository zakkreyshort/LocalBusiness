using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContextFactory : IDesignTimeDbContextFactory<LocalBusinessApiContext>
  {

    LocalBusinessApiContext IDesignTimeDbContextFactory<LocalBusinessApiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<LocalBusinessApiContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new LocalBusinessApiContext(builder.Options);
    }
  }
}