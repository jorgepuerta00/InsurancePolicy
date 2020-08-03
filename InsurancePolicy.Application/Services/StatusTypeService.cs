namespace InsurancePolicy.Application.Services
{
    using Interfaces;
    using ViewModels;
    using Domain.Interfaces;
    using Domain.Models;
    using System.Collections.Generic;

    public class StatusTypeService : BaseData, IStatusTypeService
    {
        public IRepository<StatusType> _statusTypeRepository;
        public StatusTypeService(IRepository<StatusType> statusTypeRepository)
        {
            _statusTypeRepository = statusTypeRepository;
        }

        public void CreateStatusType(StatusTypeViewModel statusTypeViewModel)
        {
            var statusType = this._mapper.Map<StatusTypeViewModel, StatusType>(statusTypeViewModel);
            _statusTypeRepository.Create(statusType);
        }

        public void DeleteStatusType(StatusTypeViewModel statusTypeViewModel)
        {
            var statusType = this._mapper.Map<StatusTypeViewModel, StatusType>(statusTypeViewModel);
            _statusTypeRepository.Delete(statusType);
        }

        public IEnumerable<StatusTypeViewModel> GetStatusTypes()
        {
            return this._mapper.Map<IEnumerable<StatusType>, IEnumerable<StatusTypeViewModel>>(_statusTypeRepository.GetAll());
        }

        public void UpdateStatusType(StatusTypeViewModel statusTypeViewModel)
        {
            var statusType = this._mapper.Map<StatusTypeViewModel, StatusType>(statusTypeViewModel);
            _statusTypeRepository.Update(statusType);
        }
    }

}