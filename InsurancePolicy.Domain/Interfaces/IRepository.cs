namespace InsurancePolicy.Domain.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
