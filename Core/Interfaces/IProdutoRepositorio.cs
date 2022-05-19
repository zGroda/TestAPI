using Core.Entidades;

namespace Core.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<Produto> GetProdutoPorId(int id);
        Task<IReadOnlyList<Produto>> GetListaDeProdutos();
        Task<Produto> PostProduto(Produto produto);
    }
}
