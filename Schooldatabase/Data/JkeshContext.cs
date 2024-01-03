using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Schooldatabase.Models;

namespace Schooldatabase.Data
{
    public class JkeshContext : DbContext
    {
        public JkeshContext (DbContextOptions<JkeshContext> options)
            : base(options)
        {
        }

        public DbSet<Schooldatabase.Models.Student> Student { get; set; } = default!;
    }
}
