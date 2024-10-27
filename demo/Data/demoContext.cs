using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demo.Models;

namespace demo.Data
{
    public class demoContext : DbContext
    {
        public demoContext (DbContextOptions<demoContext> options)
            : base(options)
        {
        }

        public DbSet<demo.Models.Category> Category { get; set; } = default!;

        public DbSet<demo.Models.Product>? Product { get; set; }

        public DbSet<demo.Models.User>? User { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
