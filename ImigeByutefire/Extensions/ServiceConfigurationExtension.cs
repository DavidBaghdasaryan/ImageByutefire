using AutoMapper;
using ImageByutefire.Mapper;

namespace ImageByutefire.Extensions
{
    public static class ServiceConfigurationExtension
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ModelsMapper());

            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
