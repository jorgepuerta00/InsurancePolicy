namespace InsurancePolicy.Infrastructure.IoC
{
    using Application.Interfaces;
    using Application.Services;
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Repositories;
    using Microsoft.Extensions.DependencyInjection;

    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICoverageTypeService, CoverageTypeService>();
            services.AddScoped<IInsurancePolicyService, InsurancePolicyService>();
            services.AddScoped<IRiskTypeService, RiskTypeService>();
            services.AddScoped<IStatusTypeService, StatusTypeService>();
        }
    }
}
