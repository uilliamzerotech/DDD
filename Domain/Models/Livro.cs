namespace Domain.Models
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
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public void AdicionarComentario(string texto, Cliente cliente)
        {
            if (Comentarios == null)
                Comentarios = new List<Comentario>();

            Comentarios.Add(new Comentario { Texto = texto, Cliente = cliente, DataPublicacao = DateTime.Now });
        }
    }
}
