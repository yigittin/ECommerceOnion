using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ExerciseReadRepository : ReadRepository<Exercise>, IExerciseReadRepository
    {
        public ExerciseReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
