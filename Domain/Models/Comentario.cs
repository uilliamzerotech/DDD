namespace Domain.Models
{
    public class Comentario
    {
        public string Texto { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
