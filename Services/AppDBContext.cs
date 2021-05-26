using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class AppDBContext :DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }

        public DbSet<Route> Routes { get; set; }
        public DbSet<Attendant> Attendants { get; set; }
    }
}
