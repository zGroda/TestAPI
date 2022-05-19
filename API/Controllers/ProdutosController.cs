using Core.Entidades;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProdutosController : BaseApiController
    {
        private readonly IProdutoRepositorio _produto;

        public ProdutosController(IProdutoRepositorio produto)
        {
            _produto = produto;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Produto>>> GetListaDeProdutos()
        {
            return Ok(await _produto.GetListaDeProdutos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutoPorId(int id)
        {
            return Ok(await _produto.GetProdutoPorId(id));
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            return Ok(await _produto.PostProduto(produto));
        }
    }
}
