using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOPOW.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Morodec> Morodci { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Morodec>().HasData(
                new Morodec { Id = 1, Name = "Rodec", Size = 14,  Date = new DateTime(2001, 12, 16), LOLRank = "Ajron třy", Address = "Do Pískovny 420 Mníšek", Term = "Naní chálec jako chálec" }
            );
        }
    }
}
