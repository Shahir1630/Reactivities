using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData
                (
                    new Value { Id = 1, Name = "Shahir" },
                    new Value { Id = 2, Name = "Ayan" },
                    new Value { Id = 3, Name = "Safin" }
                );
        }
    }
}
