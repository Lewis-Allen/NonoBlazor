using Microsoft.EntityFrameworkCore;
using NonoBlazor.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NonoBlazor.Database.Contexts
{
    public class NonogramContext : DbContext
    {
        public DbSet<StandardNonogram> StandardNonograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\Database\\Nonogram.db"));

            options.UseSqlite(@$"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StandardNonogram>()
                .ToTable("StandardNonograms");

            builder.Entity<StandardNonogram>()
                .HasData(
                    new StandardNonogram
                    {
                        ID = 1,
                        PublicID = Guid.NewGuid(),
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    },
                    new StandardNonogram
                    {
                        ID = 2,
                        PublicID = Guid.NewGuid(),
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    },
                    new StandardNonogram
                    {
                        ID = 3,
                        PublicID = Guid.NewGuid(),
                        Width = 10,
                        Height = 10,
                        ColumnValues = "3,3,3,3,3,3,3,3,3,3",
                        RowValues = "3,3,3,3,3,3,3,3,3,3"
                    }
                );
        }
    }
}
