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
            services.AddScoped<ICoverageType, CoverageTypeService>();
            services.AddScoped<ICoverageTypeRepository, CoverageTypeRepository>();

            services.AddScoped<IInsurancePolicy, InsurancePolicyService>();
            services.AddScoped<IInsurancePolicyRepository, InsurancePolicyRepository>();

            services.AddScoped<IRiskType, RiskTypeService>();
            services.AddScoped<IRiskTypeRepository, RiskTypeRepository>();

            services.AddScoped<IStatusType, StatusTypeService>();
            services.AddScoped<IStatusTypeRepository, StatusTypeRepository>();
        }
    }
}
