using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesEnvironment.Models;

    public class RazorPagesNaturalEnvironmentContext : DbContext
    {
        public RazorPagesNaturalEnvironmentContext (DbContextOptions<RazorPagesNaturalEnvironmentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesEnvironment.Models.Environment> Environment { get; set; }
    }
