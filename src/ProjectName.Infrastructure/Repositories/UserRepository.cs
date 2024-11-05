using Microsoft.EntityFrameworkCore;
using ProjectName.Application.Entities;
using ProjectName.Application.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Infrastructure.Repositories
{
    public class UserRepository(DbContext context) : GenericRepository<User>(context), IUserRepository
    {
    }
}
