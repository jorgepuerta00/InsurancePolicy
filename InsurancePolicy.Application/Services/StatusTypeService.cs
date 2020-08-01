namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class StatusTypeService : IStatusType
    {
        public IStatusTypeRepository _statusTypeRepository;
        public StatusTypeService(IStatusTypeRepository statusTypeRepository)
        {
            _statusTypeRepository = statusTypeRepository;
        }
        StatusTypeViewModel IStatusType.GetStatusTypes()
        {
            return new StatusTypeViewModel()
            {
                StatusTypes = _statusTypeRepository.GetStatusTypes()
            };
        }
    }

}