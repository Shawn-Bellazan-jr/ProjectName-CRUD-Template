using ProjectName.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Application.Interfaces.IServices
{
    public interface IService<TENTITY> where TENTITY : BaseEntity
    {
        Task AddAsync(TENTITY entity);
        Task UpdateAsync(TENTITY entity);
        Task DeleteAsync(TENTITY entity);
        Task<TENTITY?> GetByIdAsync(Guid id);
        Task<IEnumerable<TENTITY>> GetAllAsync();
    }
}
