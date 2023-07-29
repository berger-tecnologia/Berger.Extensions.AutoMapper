using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureAutoMapper<Startup, D, I, V>(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(Startup));

            services.AddAutoMapper(typeof(D), typeof(I), typeof(V));
        }
    }
}