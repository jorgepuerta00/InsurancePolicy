namespace InsurancePolicy.Infrastructure.Data.Context
{
    using System.Linq;

    public interface IDbContext
    {
        IQueryable<T> Set<T>() where T : class;
    }
}