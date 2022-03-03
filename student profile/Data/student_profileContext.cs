#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using student_profile.studentprof;

namespace student_profile.Data
{
    public class student_profileContext : DbContext
    {
        public student_profileContext (DbContextOptions<student_profileContext> options)
            : base(options)
        {
        }

        public DbSet<student_profile.studentprof.Class> Class { get; set; }
    }
}
