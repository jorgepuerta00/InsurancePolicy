namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class StatusTypeService : IStatusTypeService
    {
        public IRepository<StatusType> _statusTypeRepository;
        public StatusTypeService(IRepository<StatusType> statusTypeRepository)
        {
            _statusTypeRepository = statusTypeRepository;
        }

        public void CreateStatusType(StatusType statusType)
        {
            _statusTypeRepository.Create(statusType);
        }

        public void DeleteStatusType(StatusType statusType)
        {
            _statusTypeRepository.Delete(statusType);
        }

        public StatusTypeViewModel GetStatusTypes()
        {
            return new StatusTypeViewModel()
            {
                StatusTypes = _statusTypeRepository.GetAll()
            };
        }

        public void UpdateStatusType(StatusType statusType)
        {
            _statusTypeRepository.Update(statusType);
        }
    }

}