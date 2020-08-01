namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class CoverageTypeService : ICoverageType
    {
        public ICoverageTypeRepository _coverageTypeRepository;
        public CoverageTypeService(ICoverageTypeRepository coverageTypeRepository)
        {
            _coverageTypeRepository = coverageTypeRepository;
        }
        CoverageTypeViewModel ICoverageType.GetCoverageTypes()
        {
            return new CoverageTypeViewModel()
            {
                CoverageTypes = _coverageTypeRepository.GetCoverageTypes()
            };
        }
    }
}
