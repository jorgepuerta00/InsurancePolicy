using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;

    public class CoverageTypeService : ICoverageType
    {
        CoverageTypeViewModel ICoverageType.GetCoverageTypes()
        {
            throw new NotImplementedException();
        }
    }
}
