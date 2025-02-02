﻿using EntityFrameworkConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Data
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Setting> Settings { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                                                                           
              optionsBuilder.UseSqlServer("Server=DESKTOP-3F8EQGP\\SQLEXPRESS;Database=EntityFrameworkPB101Db;Trusted_Connection=true; TrustServerCertificate=True");
        }

    }
}
