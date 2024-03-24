using Data.Contexts;
using Data.Entity;
using Services.Interfaces;


namespace Services.Services
{
    public class LivroService : ILivroService
    {
        private readonly Contexto _ctx;

        public LivroService(Contexto ctx)
        {
            _ctx = ctx;
        }

        public Livro ObterLivroPorId(int livroId)
        {
            return _ctx.Livros.Find(livroId);
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            return _ctx.Livros.ToList();
        }

        public void AdicionarLivro(Livro livro)
        {
            _ctx.Livros.Add(livro);
            _ctx.SaveChanges();
        }

        public void AtualizarLivro(Livro livro)
        {
            _ctx.Livros.Update(livro);
            _ctx.SaveChanges();
        }

        public void RemoverLivro(int livroId)
        {
            var livro = _ctx.Livros.Find(livroId);
            if (livro != null)
            {
                _ctx.Livros.Remove(livro);
                _ctx.SaveChanges();
            }
        }

        public void AdicionarComentario(int livroId, string textoComentario, Cliente cliente)
        {
            var livro = _ctx.Livros.Find(livroId);
            if (livro != null)
            {
                livro.Comentarios ??= new List<Comentario>();
                livro.Comentarios.Add(new Comentario { Texto = textoComentario, ClienteId = cliente.Id, DataPublicacao = DateTime.Now });
                _ctx.SaveChanges();
            }
        }
    }
}
