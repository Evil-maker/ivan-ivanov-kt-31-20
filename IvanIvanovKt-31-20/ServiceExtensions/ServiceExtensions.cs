using IvanIvanovKt_31_20.Interfaces.StudentsInterfaces;

namespace IvanIvanovKt_31_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services; 
        }
    }
}
