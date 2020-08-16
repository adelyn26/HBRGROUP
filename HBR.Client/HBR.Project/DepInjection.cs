using HBR.Services.Category;
using HBR.Services.Products;
using HBR.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace HBR.Project
{
    public static class DepInjection
    {
        public static IServiceCollection Injection(this IServiceCollection services)
        {
            services.AddScoped<ICategoriesService, CategoriesService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
      
    }
}
