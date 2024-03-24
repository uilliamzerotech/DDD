using Application.Dto;
using Application.Mapping;
using Data.Entity;
using Services.Interfaces;

namespace Application.ApplicationServices
{

    public class LivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public void AdicionarComentario(int livroId, string textoComentario, ClienteDTO cliente)
        {
            var _cliente = new ClienteMap().MapToCliente(cliente);
            _livroService.AdicionarComentario(livroId, textoComentario, _cliente);
        }

        public void AdicionarLivro(Livro livro)
        {
            _livroService.AdicionarLivro(livro);
        }

        public void AtualizarLivro(Livro livro)
        {
            _livroService.AtualizarLivro(livro);
        }

        public Livro ObterLivroPorId(int livroId)
        {
            return _livroService.ObterLivroPorId(livroId);
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            return _livroService.ObterTodosLivros();
        }

        public void RemoverLivro(int livroId)
        {
            _livroService.RemoverLivro(livroId);
        }
    }
}
