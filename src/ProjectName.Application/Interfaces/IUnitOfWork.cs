using ProjectName.Application.Entities;
using ProjectName.Application.Interfaces.IRepositories;

namespace ProjectName.Application.Interfaces
{
    public interface IUnitOfWork<TENTITY> : IDisposable where TENTITY : BaseEntity
    {
        IRepository<TENTITY> Repository { get; }

        Task<int> SaveChangesAsync();

    }
}
