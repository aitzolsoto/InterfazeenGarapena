﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AginteKoadroa.Models
{
    public class SalmentaDbContext : DbContext
    {
        public SalmentaDbContext() : base(nameOrConnectionString: "SalmentaDbContext")
        { }
        public DbSet<Bezeroa> Bezeroa { get; set; }
        public DbSet<Salmenta> Salmenta { get; set; }
        public DbSet<Saltzailea> Saltzailea { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
