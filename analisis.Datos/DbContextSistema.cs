using analisis.Datos.Mapping.Almacen;
using analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
