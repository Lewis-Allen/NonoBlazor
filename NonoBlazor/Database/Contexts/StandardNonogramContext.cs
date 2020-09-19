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
                        Width = 10,
                        Height = 10,
                        ColumnValues = "7 1,7 2,6,5 1,4 1 2,1 1 3,4,1 5,3 5,3 6",
                        RowValues = "6 1,5 2,5 3,5 1,4 1 1,3 1 3,2 1 4,5,1 6,2 6"
                    },
                    new StandardNonogram
                    {
                        ID = 2,
                        Width = 10,
                        Height = 10,
                        ColumnValues = "4,2 1,3 1,1 4 2,1 2 1,2 1 1,2 2,2,2,1",
                        RowValues = "4,2 2,2 1,1 1,1 1,1 1,1 2,1 2 2,2 3,5"
                    },
                    new StandardNonogram
                    {
                        ID = 3,
                        Width = 10,
                        Height = 10,
                        ColumnValues = "2,1 1 1,1 2 3,1 1 6,1 1 1,1 2,2 1 1,2 1 2,3 3,5",
                        RowValues = "4,2 2,1 1 1,3 1,2 1,1 2,1 1 1,3 1 2,2 1 3,9"
                    },
                    new StandardNonogram
                    {
                        ID = 4,
                        Width = 5,
                        Height = 5,
                        ColumnValues = "3,1 3,5,3 1,3",
                        RowValues = "3,1 3,5,3 1,3"
                    },
                    new StandardNonogram
                    {
                        ID = 5,
                        Width = 5,
                        Height = 5,
                        ColumnValues = "2,1 1,3 1,4,3",
                        RowValues = "3,4,1 3,1 1,2"
                    }
                );
        }
    }
}
