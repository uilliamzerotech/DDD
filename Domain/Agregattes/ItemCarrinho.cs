using Domain.Models;

namespace Domain.Agregattes
{
    public class ItemCarrinho
    {
        public Livro Livro { get; set; }
        public int Quantidade { get; set; }
    }
}
