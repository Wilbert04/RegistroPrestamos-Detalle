using Microsoft.EntityFrameworkCore;
using RegistroPrestamosDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> personas { get; set; }
        public DbSet<Prestamos> prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\ProductoDB.db");
        }
    }
}
