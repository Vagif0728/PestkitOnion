using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generic;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext context):base(context)
        {

        }
    }
}
