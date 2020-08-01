using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    public class StatusTypeService : IStatusType
    {
        StatusTypeViewModel IStatusType.GetStatusTypes()
        {
            throw new NotImplementedException();
        }
    }

}