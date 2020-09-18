using Microsoft.EntityFrameworkCore;
using NonoBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NonoBlazor.Database.Contexts
{
    public class NonogramContext : DbContext
    {
        public DbSet<StandardNonogram> StandardNonograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\i7 Pro Gamer\source\repos\NonoBlazor\NonoBlazor\Database\Nonogram.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StandardNonogram>()
                .ToTable("StandardNonograms");

            builder.Entity<StandardNonogram>()
                .HasData(
                    new StandardNonogram
                    {
                        StandardNonogramID = 1,
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    },
                    new StandardNonogram
                    {
                        StandardNonogramID = 2,
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    },
                    new StandardNonogram
                    {
                        StandardNonogramID = 3,
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    }
                );
        }
    }
}
