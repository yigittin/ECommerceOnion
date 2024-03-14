using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ExerciseImageWriteRepository : WriteRepository<ExerciseImage>, IExerciseImageWriteRepository
    {
        public ExerciseImageWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
