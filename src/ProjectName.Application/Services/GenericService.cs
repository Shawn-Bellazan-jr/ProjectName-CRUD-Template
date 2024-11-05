using ProjectName.Application.Entities;
using ProjectName.Application.Interfaces;
using ProjectName.Application.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Application.Services
{
    public class GenericService<TENTITY> : IService<TENTITY> where TENTITY : BaseEntity
    {
        private readonly IUnitOfWork<TENTITY> _unitOfWork;

        protected GenericService(IUnitOfWork<TENTITY> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(TENTITY entity)
        {
            await _unitOfWork.Repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(TENTITY entity)
        {
            var entityToDelete = await _unitOfWork.Repository.GetByIdAsync(Guid.Parse(entity.Id));

            if (entityToDelete != null)
            {
                await _unitOfWork.Repository.DeleteAsync(entityToDelete);
                await _unitOfWork.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<TENTITY>> GetAllAsync() => await _unitOfWork.Repository.GetAllAsync();

        public async Task<TENTITY?> GetByIdAsync(Guid id) => await _unitOfWork.Repository.GetByIdAsync(id);

        public async Task UpdateAsync(TENTITY entity)
        {
            await _unitOfWork.Repository.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
