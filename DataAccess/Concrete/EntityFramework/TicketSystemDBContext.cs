using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class TicketSystemDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TicketSystemDB;Trusted_Connection=true");
        }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Sefer> Seferler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
    }
}