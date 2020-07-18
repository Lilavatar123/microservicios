using Microservicios.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservicios.Infraestructura
{

    public class PersistenceContext : DbContext
    {


        private readonly IConfiguration Config;

        public PersistenceContext(DbContextOptions<PersistenceContext> options, IConfiguration config) : base(options)
        {
            Config = config;


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }
            modelBuilder.HasDefaultSchema(Config.GetValue<string>("SchemaName"));
            modelBuilder.Entity<Producto>();
            base.OnModelCreating(modelBuilder);
        }
    }


}
