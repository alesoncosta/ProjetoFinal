namespace Projeto.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemVenda> Itens { get; set; }
        public decimal TotalVenda { get; set; }
    }
}
