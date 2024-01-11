namespace Projeto.Models
{
    public class VendaViewModel
    {
        public virtual Cliente oCliente { get; set; }
        public virtual Produto oProduto { get; set; }
        public List<Cliente>? oListCliente { get; set; }
        public List<Produto>? oListProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? ValorTotal { get; set; }
        public List<ItemVendaViewModel>? Itens { get; set; }

        public VendaViewModel()
        {
            oListCliente = new List<Cliente>();
            oListProduto = new List<Produto>();
            Itens = new List<ItemVendaViewModel>();
        }
    }
}
