
namespace Application.Dto
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Sinopse { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int AnoPublicacao { get; set; }
        public string AutorNome { get; set; }
        public string EditoraNome { get; set; }
    }
}
