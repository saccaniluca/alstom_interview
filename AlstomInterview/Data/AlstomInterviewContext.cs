using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlstomInterview.Models;

namespace AlstomInterview.Data
{
    public class AlstomInterviewContext : DbContext
    {
        public AlstomInterviewContext (DbContextOptions<AlstomInterviewContext> options)
            : base(options)
        {
        }

        public DbSet<AlstomInterview.Models.Problem> Problem { get; set; } = default!;
    }
}
