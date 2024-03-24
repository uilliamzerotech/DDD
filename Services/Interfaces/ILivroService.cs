using Data.Entity;

namespace Services.Interfaces
{
    public interface ILivroService
    {
        void AdicionarComentario(int livroId, string textoComentario, Cliente cliente);
        void AdicionarLivro(Livro livro);
        void AtualizarLivro(Livro livro);
        Livro ObterLivroPorId(int livroId);
        IEnumerable<Livro> ObterTodosLivros();
        void RemoverLivro(int livroId);
    }
}