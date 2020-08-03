namespace InsurancePolicy.Application.ViewModels
{
    using AutoMapper;
    using Domain.Models;

    public class BaseData
    {
        protected IMapper _mapper;

        public BaseData()
        {
            AutoMapperConfiguration();
        }
        private void AutoMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CoverageTypeViewModel, CoverageType>().ReverseMap();
                cfg.CreateMap<InsurancePolicyViewModel, InsurancePolicy>().ReverseMap();
                cfg.CreateMap<RiskTypeViewModel, RiskType>().ReverseMap();
                cfg.CreateMap<StatusTypeViewModel, StatusType>().ReverseMap();
            });
            this._mapper = config.CreateMapper();
        }
    }
}
