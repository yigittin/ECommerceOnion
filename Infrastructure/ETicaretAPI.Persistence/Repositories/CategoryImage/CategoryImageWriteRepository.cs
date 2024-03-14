using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CategoryImageWriteRepository : WriteRepository<CategoryImage>, ICategoryImageWriteRepository
    {
        public CategoryImageWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
