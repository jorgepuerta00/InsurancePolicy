using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;

    public class RiskTypeService : IRiskType
    {
        RiskTypeViewModel IRiskType.GetRiskTypes()
        {
            throw new NotImplementedException();
        }
    }
}
