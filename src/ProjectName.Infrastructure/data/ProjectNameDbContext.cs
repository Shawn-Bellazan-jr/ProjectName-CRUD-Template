using Microsoft.EntityFrameworkCore;
using ProjectName.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Infrastructure.data
{
    public class ProjectNameDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public ProjectNameDbContext()
        {

        }
    }
}
