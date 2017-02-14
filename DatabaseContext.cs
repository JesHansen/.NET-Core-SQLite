using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFSQLite
{
  class ChinookContext : DbContext
  {
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      RemovePluralizingTableNameConvention(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(@"Data Source=Data\Chinook_Sqlite_AutoIncrementPKs.sqlite");
      base.OnConfiguring(optionsBuilder);
    }

    public static void RemovePluralizingTableNameConvention(ModelBuilder modelBuilder)
    {
      foreach (var entity in modelBuilder.Model.GetEntityTypes())
      {
        entity.Relational().TableName = entity.DisplayName();
      }
    }
  }
}
