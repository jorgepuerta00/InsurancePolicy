using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class RiskTypeService : IRiskType
    {
        public IRiskTypeRepository _RiskTypeRepository;
        public RiskTypeService(IRiskTypeRepository RiskTypeRepository)
        {
            _RiskTypeRepository = RiskTypeRepository;
        }
        RiskTypeViewModel IRiskType.GetRiskTypes()
        {
            throw new NotImplementedException();
        }
    }
}
