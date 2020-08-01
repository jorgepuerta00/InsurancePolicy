using System;

namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class StatusTypeService : IStatusType
    {
        public IStatusTypeRepository _StatusTypeRepository;
        public StatusTypeService(IStatusTypeRepository StatusTypeRepository)
        {
            _StatusTypeRepository = StatusTypeRepository;
        }
        StatusTypeViewModel IStatusType.GetStatusTypes()
        {
            throw new NotImplementedException();
        }
    }

}