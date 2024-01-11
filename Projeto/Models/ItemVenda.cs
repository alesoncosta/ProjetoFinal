namespace Projeto.Models
{
    public class ItemVenda
    {
            public int ItemVendaId { get; set; }
            public int ProdutoId { get; set; }
            public virtual Produto Produto { get; set; }
            public int VendaId { get; set; }
            public virtual Venda Venda { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }
            public decimal ValorTotal { get; set; }
    }
}
