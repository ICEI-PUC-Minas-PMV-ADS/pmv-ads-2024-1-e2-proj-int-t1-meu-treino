using Microsoft.EntityFrameworkCore;

namespace BackEndMeutreino.Models
{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Exercicio> Exercicio { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        
        public DbSet<HistoricoPeso> HistoricoPeso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuario");
            modelBuilder.Entity<Exercicio>().ToTable("exercicio");
            modelBuilder.Entity<Favoritos>().ToTable("favoritos");
            modelBuilder.Entity<Avaliacao>().ToTable("avaliacao");
            modelBuilder.Entity<HistoricoPeso>().ToTable("historicoPeso");

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Favoritos)
                .WithOne(f => f.usuario)
                .HasForeignKey(f => f.idUsuario);

            modelBuilder.Entity<Favoritos>()
                .HasOne(f => f.exercicio)
                .WithMany(e => e.Favoritos)
                .HasForeignKey(f => f.idExercicio);

            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.usuario)
                .WithMany(u => u.Avaliacao)
                .HasForeignKey(a => a.idUsuario);

            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.exercicio)
                .WithMany(e => e.Avaliacoes)
                .HasForeignKey(a => a.idExercicio);

            modelBuilder.Entity<HistoricoPeso>()
                .HasOne(h => h.usuario)
                .WithMany(u => u.HistoricoPeso)
                .HasForeignKey(h => h.idUsuario);

        }
       
    }
}
