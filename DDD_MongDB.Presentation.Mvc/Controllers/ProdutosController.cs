using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DDD_MongDB.Presentation.Mvc.Controllers
{
    [Produces("application/json")]
    [Route("api/Produtos")]
    public class ProdutosController : Controller
    {
        private readonly IAppProdutoServico _produtoServico;

        public ProdutosController(IAppProdutoServico produtoServico) => _produtoServico = produtoServico;

        [HttpGet]
        public ICollection<Produto> ListarTodos() => _produtoServico.ListarTodos();

        [HttpPost]
        public void Incluir([FromBody]Produto produto) => _produtoServico.Incluir(produto);
    }
}