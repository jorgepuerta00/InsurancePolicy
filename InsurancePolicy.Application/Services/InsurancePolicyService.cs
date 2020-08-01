using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;

    public class InsurancePolicyService : IInsurancePolicy
    {
        InsurancePolicyViewModel IInsurancePolicy.GetInsurancePolicies()
        {
            throw new NotImplementedException();
        }
    }
}
