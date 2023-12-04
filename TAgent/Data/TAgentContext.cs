﻿
using Microsoft.EntityFrameworkCore;
using TAgent.Models;

namespace TAgent.Data
{
    public class ContosoPizzaContext : DbContext
    {
        public DbSet<User> Customers { get; set; }
        public DbSet<VisaApp> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;");
        }
    }
}
