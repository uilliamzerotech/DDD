

namespace Data.Entity
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Sinopse { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int AnoPublicacao { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
