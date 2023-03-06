using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeWebApp.Models;

namespace PracticeWebApp.Data
{
    public class PracticeWebAppContext : DbContext
    {
        public PracticeWebAppContext (DbContextOptions<PracticeWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeWebApp.Models.Pizza> Pizza { get; set; } = default!;
    }
}
