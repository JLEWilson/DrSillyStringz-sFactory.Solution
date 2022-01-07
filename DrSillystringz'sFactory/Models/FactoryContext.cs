using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class RegistrarContext: DbContext
  {
    //Add dbsets here for each database
    public FactoryContext(DbContextOptions options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}