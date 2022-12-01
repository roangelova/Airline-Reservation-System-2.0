using ARS.Persistance.GenericRepository;
using ARS.Persistance.Repositories;
using ARS.Persistance.Repositories.Contracts;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;
using ARS.Service.Services;

namespace ARS.Api.ServiceExtensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMemoryCache();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAirlineRepository, AirlineRepository>();
            services.AddScoped<ICrewMemberRepository, CrewMembeRepository>();
            services.AddScoped<IAircraftRepository, AircraftRepository>();

            services.AddScoped<IAirlineService, AirlineService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICrewMemberService, CrewMemberService>();
            services.AddScoped<IAircraftService, AircraftService>();
            services.AddScoped<IFlightService, FlightService>();

            return services;
        }

    }
}
