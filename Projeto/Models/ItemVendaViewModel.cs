namespace Projeto.Models
{
    public class ItemVendaViewModel
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }       
        public Produto Produto { get; set; }       
        public decimal ValorTotalItem => Produto != null ? Produto.Valor * Quantidade : 0;
        public decimal ValorTotal => ValorTotalItem;
    }
}
