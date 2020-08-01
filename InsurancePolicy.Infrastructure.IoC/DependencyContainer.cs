namespace InsurancePolicy.Infrastructure.IoC
{
    using Application.Interfaces;
    using Application.Services;
    using Domain.Interfaces;
    using Data.Repositories;
    using Microsoft.Extensions.DependencyInjection;

    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICoverageTypeService, CoverageTypeService>();
            services.AddScoped<ICoverageTypeRepository, CoverageTypeRepository>();

            services.AddScoped<IInsurancePolicyService, InsurancePolicyService>();
            services.AddScoped<IInsurancePolicyRepository, InsurancePolicyRepository>();

            services.AddScoped<IRiskTypeService, RiskTypeService>();
            services.AddScoped<IRiskTypeRepository, RiskTypeRepository>();

            services.AddScoped<IStatusTypeService, StatusTypeService>();
            services.AddScoped<IStatusTypeRepository, StatusTypeRepository>();
        }
    }
}
