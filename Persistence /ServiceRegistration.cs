using Application.Repositories;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using Persistence.Repositories.UserRepo;
using Persistence.Services;
using Persistence.Services.Login;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            // Db Context
            services.AddDbContext<ECommerceAPIDbContext>(options =>
                options.UseNpgsql(Configuration.ConnectionString));
            // Dependency Injection Container:
            // Repositories
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICartReadRepository, CartReadRepository>();
            services.AddScoped<ICartWriteRepository, CartWriteRepository>();
            services.AddScoped<ICartItemReadRepository, CartItemReadRepository>();
            services.AddScoped<ICartItemWriteRepository, CartItemWriteRepository>();
         
            // Services
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICategoriesService, CategoriesService>();
            services.AddScoped<ICartService, CartService>();
        }
    }
}