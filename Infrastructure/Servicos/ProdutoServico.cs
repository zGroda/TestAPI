using Core.Entidades;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servicos
{
    public class ProdutoServico : IProdutoRepositorio
    {
        private readonly StoreContext _context;

        public ProdutoServico(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Produto>> GetListaDeProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutoPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<Produto> PostProduto(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            _context.SaveChanges();
            return produto;
        }
    }
}
