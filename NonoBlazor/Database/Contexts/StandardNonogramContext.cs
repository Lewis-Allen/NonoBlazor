using Microsoft.EntityFrameworkCore;
using NonoBlazor.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

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
                .Property(sn => sn.RowValues)
                .HasConversion(
                    v => string.Join(",", v.Select(u => string.Join(" ", u))),
                    v => v.Split(",", StringSplitOptions.None).ToList().Select(u => u.Split(" ", StringSplitOptions.None).ToList().Select(x => int.Parse(x)).ToList()).ToList()
                );

            builder.Entity<StandardNonogram>()
                .Property(sn => sn.ColumnValues)
                .HasConversion(
                    v => string.Join(",", v.Select(u => string.Join(" ", u))),
                    v => v.Split(",", StringSplitOptions.None).ToList().Select(u => u.Split(" ", StringSplitOptions.None).ToList().Select(x => int.Parse(x)).ToList()).ToList()
                );

            builder.Entity<StandardNonogram>()
                .HasData(
                    new StandardNonogram
                    {
                        ID = 1,
                        Width = 5,
                        Height = 5,
                        ColumnValues = new List<List<int>>
                        {
                            new List<int> { 3 },
                            new List<int> { 1, 3 },
                            new List<int> { 5 },
                            new List<int> { 3, 1 },
                            new List<int> { 3 }
                        },
                        RowValues = new List<List<int>>
                        {
                            new List<int> { 3 },
                            new List<int> { 1, 3 },
                            new List<int> { 5 },
                            new List<int> { 3, 1 },
                            new List<int> { 3 }
                        }
                    },
                    new StandardNonogram
                    {
                        ID = 2,
                        Width = 5,
                        Height = 5,
                        ColumnValues = new List<List<int>>
                        {
                            new List<int> { 2 },
                            new List<int> { 1, 1 },
                            new List<int> { 3, 1 },
                            new List<int> { 4 },
                            new List<int> { 3 }
                        },
                        RowValues = new List<List<int>>
                        {
                            new List<int> { 3 },
                            new List<int> { 4 },
                            new List<int> { 1, 3 },
                            new List<int> { 1, 1 },
                            new List<int> { 2 }
                        }
                    },
                    new StandardNonogram
                    {
                        ID = 3,
                        Width = 10,
                        Height = 10,
                        ColumnValues = new List<List<int>>
                        {
                            new List<int> { 7, 1 },
                            new List<int> { 7, 2 },
                            new List<int> { 6 },
                            new List<int> { 5, 1 },
                            new List<int> { 4, 1, 2 },
                            new List<int> { 1, 1, 3 },
                            new List<int> { 4 },
                            new List<int> { 1, 5 },
                            new List<int> { 3, 5 },
                            new List<int> { 3, 6 }
                        },
                        RowValues = new List<List<int>>
                        {
                            new List<int> { 6, 1 },
                            new List<int> { 5, 2 },
                            new List<int> { 5, 3 },
                            new List<int> { 5, 1 },
                            new List<int> { 4, 1, 1 },
                            new List<int> { 3, 1, 3 },
                            new List<int> { 2, 1, 4 },
                            new List<int> { 5 },
                            new List<int> { 1, 6 },
                            new List<int> { 2, 6 }
                        }
                    },
                    new StandardNonogram
                    {
                        ID = 4,
                        Width = 10,
                        Height = 10,
                        ColumnValues = new List<List<int>>
                        {
                            new List<int> { 4 },
                            new List<int> { 2, 1 },
                            new List<int> { 3, 1 },
                            new List<int> { 1, 4, 2 },
                            new List<int> { 1, 2, 1 },
                            new List<int> { 2, 1, 1 },
                            new List<int> { 2, 2 },
                            new List<int> { 2 },
                            new List<int> { 2 },
                            new List<int> { 1 }
                        },
                        RowValues = new List<List<int>>
                        {
                            new List<int> { 4 },
                            new List<int> { 2, 2 },
                            new List<int> { 2, 1 },
                            new List<int> { 1, 1 },
                            new List<int> { 1, 1 },
                            new List<int> { 1, 1 },
                            new List<int> { 1, 2 },
                            new List<int> { 1, 2, 2 },
                            new List<int> { 2, 3 },
                            new List<int> { 5 }
                        }
                    },
                    new StandardNonogram
                    {
                        ID = 5,
                        Width = 10,
                        Height = 10,
                        ColumnValues = new List<List<int>>
                        {
                            new List<int> { 2 },
                            new List<int> { 1, 1, 1 },
                            new List<int> { 1, 2, 3 },
                            new List<int> { 1, 1, 6 },
                            new List<int> { 1, 1, 1 },
                            new List<int> { 1, 2 },
                            new List<int> { 2, 1, 1 },
                            new List<int> { 2, 1, 2 },
                            new List<int> { 3, 3 },
                            new List<int> { 5 }
                        },
                        RowValues = new List<List<int>>
                        {
                            new List<int> { 4 },
                            new List<int> { 2, 2 },
                            new List<int> { 1, 1, 1 },
                            new List<int> { 3, 1 },
                            new List<int> { 2, 1 },
                            new List<int> { 1, 2 },
                            new List<int> { 1, 1, 1 },
                            new List<int> { 3, 1, 2 },
                            new List<int> { 2, 1, 3 },
                            new List<int> { 9 }
                        }
                    }
                );
        }
    }
}
