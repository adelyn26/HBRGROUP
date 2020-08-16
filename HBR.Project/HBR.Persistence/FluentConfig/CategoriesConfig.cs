using HBR.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HBR.Persistence.FluentConfig
{
    public static class CategoriesConfig
    {
        public static ModelBuilder Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(opt =>
            {
                opt.HasKey(x => x.id_Categories);
            });

            return modelBuilder;
        }
    }
}
