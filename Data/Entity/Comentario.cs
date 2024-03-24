namespace Data.Entity
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
