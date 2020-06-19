using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie_kang.Models;

namespace RazorPagesMovie_kang.Data
{
    public class RazorPagesMovie_kangContext : DbContext
    {
        public RazorPagesMovie_kangContext (DbContextOptions<RazorPagesMovie_kangContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie_kang.Models.Movie> Movie { get; set; }
    }
}
