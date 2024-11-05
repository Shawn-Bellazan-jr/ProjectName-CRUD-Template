using ProjectName.Application.Entities;
using ProjectName.Application.Interfaces;
using ProjectName.Application.Interfaces.IRepositories;
using ProjectName.Infrastructure.data;
using ProjectName.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Infrastructure
{
    public class UnitOfWork<TENTITY> : IUnitOfWork<TENTITY> where TENTITY : BaseEntity
    {
        private readonly ProjectNameDbContext _context;
        public UnitOfWork(ProjectNameDbContext context)
        {
            _context = context;
    
            // may need to initialize repositories instance as a generic type
            Repository = new GenericRepository<TENTITY>(context);
        }

        public IRepository<TENTITY> Repository { get; set; }
        public void Dispose() => _context.Dispose();
        public async Task DisposeAsync() => await _context.DisposeAsync();
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
    
}
