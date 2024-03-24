using Application.Dto;
using Domain.Models;

namespace Application.Mapping
{
    public class LivroMap
    {
        // Métodos auxiliares para mapear entre LivroDTO e Livro
        public LivroDTO MapToLivroDTO(Livro livro)
        {
            return new LivroDTO
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                ISBN = livro.ISBN,
                Sinopse = livro.Sinopse,
                Preco = livro.Preco,
                QuantidadeDisponivel = livro.QuantidadeDisponivel,
                AnoPublicacao = livro.AnoPublicacao,
                AutorNome = livro.Autor?.Nome,
                EditoraNome = livro.Editora?.Nome
                // Adicione mais mapeamentos conforme necessário
            };
        }

        public Livro MapToLivro(LivroDTO livroDTO)
        {
            return new Livro
            {
                Id = livroDTO.Id,
                Titulo = livroDTO.Titulo,
                ISBN = livroDTO.ISBN,
                Sinopse = livroDTO.Sinopse,
                Preco = livroDTO.Preco,
                QuantidadeDisponivel = livroDTO.QuantidadeDisponivel,
                AnoPublicacao = livroDTO.AnoPublicacao,
                Autor = new Autor { Nome = livroDTO.AutorNome }, // Considerando que apenas o nome é suficiente para mapeamento
                Editora = new Editora { Nome = livroDTO.EditoraNome }
                // Adicione mais mapeamentos conforme necessário
            };
        }
    }
}
