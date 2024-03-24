using Domain.Models;

namespace Domain.Agregattes
{
    public class CarrinhoDeCompras
    {
        public List<ItemCarrinho> Itens { get; set; }
        public Cliente Cliente { get; set; }

        public CarrinhoDeCompras(Cliente cliente)
        {
            Cliente = cliente;
            Itens = new List<ItemCarrinho>();
        }

        public void AdicionarItem(Livro livro, int quantidade)
        {
            var itemExistente = Itens.Find(item => item.Livro.Id == livro.Id);
            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                Itens.Add(new ItemCarrinho { Livro = livro, Quantidade = quantidade });
            }
        }

        public void RemoverItem(int livroId)
        {
            var itemExistente = Itens.Find(item => item.Livro.Id == livroId);
            if (itemExistente != null)
            {
                Itens.Remove(itemExistente);
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Itens)
            {
                total += item.Livro.Preco * item.Quantidade;
            }
            return total;
        }
    }
}
