using Microsoft.EntityFrameworkCore;
using NonoBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NonoBlazor.Server.db
{
    public class StandardNonogramContext : DbContext
    {
        public DbSet<StandardNonogram> StandardNonograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=StandardNonogram.db");
    }
}
