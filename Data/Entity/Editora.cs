namespace Data.Entity
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int AnoFundacao { get; set; }
        public List<Livro> LivrosPublicados { get; set; }
    }
}
