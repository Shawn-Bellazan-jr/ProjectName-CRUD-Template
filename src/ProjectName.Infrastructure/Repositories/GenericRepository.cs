using Microsoft.EntityFrameworkCore;
using ProjectName.Application.Entities;
using ProjectName.Application.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Infrastructure.Repositories
{
    public class GenericRepository<TENTITY> : IRepository<TENTITY> where TENTITY : BaseEntity
    {
        private readonly DbContext _context;
        private DbSet<TENTITY> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TENTITY>();
        }

        public async Task AddAsync(TENTITY entity) => await _entities.AddAsync(entity);
        public async Task DeleteAsync(TENTITY entity) => await Task.Run(() => _entities.Remove(entity));

        public async Task<IEnumerable<TENTITY>> FindAsync(Expression<Func<TENTITY, bool>> predicate) => await _entities.Where(predicate).ToListAsync();

        public async Task<IEnumerable<TENTITY>> GetAllAsync() => await _entities.ToListAsync();

        public async Task<TENTITY?> GetByIdAsync(Guid id) => await _entities.FindAsync(id);

        public async Task UpdateAsync(TENTITY entity) => await Task.Run(() => _entities.Update(entity));
    }
}
