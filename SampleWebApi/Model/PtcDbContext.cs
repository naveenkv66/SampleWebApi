using Microsoft.EntityFrameworkCore;

namespace SampleWebApi.Model
{
  public class PtcDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<AppUser> Users { get; set; }
    public DbSet<AppUserClaim> Claims { get; set; }

        private const string CONN =
                      @"Data Source=DESKTOP-QJL8KFU\SQLEXPRESS;Initial Catalog=PTC-Pluralsight;User ID=sa;Password=@bcd123";

    //    private const string CONN = @"Server=(localdb)\MSSQLLocalDB;
    //Database=PTC-Pluralsight;
    //AttachDbFilename=D:\TokenBasedAuth\angular-security-json-web-tokens\08\demos\demo\SqlData\PTC-Pluralsight.mdf;
    //MultipleActiveResultSets=true";

    protected override void OnConfiguring(
                DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(CONN);
    }
  }
}
