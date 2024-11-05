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
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IUnitOfWork<User> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
