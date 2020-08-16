using HBR.Persistence.FluentConfig;
using HBR.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HBR.Persistence
{
    public class HbrContext : DbContext
    {
        public HbrContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Product{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Usersconfig.Configuration(modelBuilder);
            ProductConfig.Configuration(modelBuilder);
            CategoriesConfig.Configuration(modelBuilder);
            //modelBuilder.Entity<Categories>().HasQueryFilter(x => x.id_Categories == 1);
        }
    }
}
