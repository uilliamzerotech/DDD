using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class Contexto:DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.AutorId);

            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Editora)
                .WithMany(e => e.LivrosPublicados)
                .HasForeignKey(l => l.EditoraId);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Livro)
                .WithMany(l => l.Comentarios)
                .HasForeignKey(c => c.LivroId);
        }
    }
}
