using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class ExerciseVideo:File
    {
        public Exercise ExerciseId { get; set; }
        public Guid Exercise{ get; set; }
        public TimeSpan VideoLength { get; set; }
    }
}
