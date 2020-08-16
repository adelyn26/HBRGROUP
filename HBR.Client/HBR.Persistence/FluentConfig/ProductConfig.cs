using HBR.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HBR.Persistence.FluentConfig
{
    public static class ProductConfig
    {
        public static ModelBuilder Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(opt =>
            {
                opt.ToTable("Product");
                opt.HasKey(x => x.id_Product);

                opt.HasOne(x => x.idCategories)
                .WithMany(y => y.product);
                //.HasForeignKey(b => b.idCategories.id_Categories);
            });

            return modelBuilder;
        }
    }
}
