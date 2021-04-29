namespace MVCCrudApi.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDContext : DbContext
    {
        public BDContext()
            : base("name=BDContext")
        {
        }

        public virtual DbSet<people> people { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<people>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usuarioced)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.correo)
                .IsUnicode(false);
        }
    }
}
