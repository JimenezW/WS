namespace WS_Prueba.Model
{
    using System.Data.Entity;

    public partial class DB_Prueba : DbContext
    {
        public DB_Prueba()
            : base("name=DB_Prueba")
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
