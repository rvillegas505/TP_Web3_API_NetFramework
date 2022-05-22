using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tp3ApiNetFramework.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Peliculas> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peliculas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Peliculas>()
                .Property(e => e.Genero)
                .IsUnicode(false);
        }
    }
}
