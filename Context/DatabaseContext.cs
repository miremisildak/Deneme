using Microsoft.EntityFrameworkCore;
using Preon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preon.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { }

        public DbSet<City> Cities { get; set; }
    }
}
