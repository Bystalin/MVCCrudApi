namespace MVCCrudApi.Models.Entities
{
    using System.Data.Entity;

    public partial class BD : DbContext
    {
        public BD()
            : base("name=BD")
        {
        }

        public virtual DbSet<people> people { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<people>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
