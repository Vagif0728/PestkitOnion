using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generic;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    internal class PositionRepository : Repository<Position>,IPositionRepository
    {
        public PositionRepository(AppDbContext context):base(context) 
        {

        }
    }
}
