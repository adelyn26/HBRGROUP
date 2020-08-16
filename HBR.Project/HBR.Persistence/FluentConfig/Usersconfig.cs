using HBR.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HBR.Persistence.FluentConfig
{
    public static class Usersconfig
    {
        public static ModelBuilder Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(opt =>
            {
                opt.HasKey(x => x.id_User);

                opt.Property(x => x._Name);
            });

            return modelBuilder;
        } 
    }
}
