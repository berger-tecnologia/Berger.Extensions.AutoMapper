using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        private static void ConfigureStartup<T>(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(T));
        }
        public static void ConfigureAutoMapper<Startup, TSource, TDestination>(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            services.ConfigureStartup<Startup>();

            services.AddAutoMapper(typeof(TSource), typeof(TDestination));
        }
        public static void ConfigureAutoMapper<Startup, D, I, V>(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            services.ConfigureStartup<Startup>();

            services.AddAutoMapper(typeof(D), typeof(I), typeof(V));
        }
    }
}