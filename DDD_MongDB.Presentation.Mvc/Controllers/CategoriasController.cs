using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DDD_MongDB.Presentation.Mvc.Controllers
{
    [Produces("application/json")]
    [Route("api/Categorias")]
    public class CategoriasController : Controller
    {
        private IAppCategoriaServico _servico;

        public CategoriasController(IAppCategoriaServico servico) => _servico = servico;

        // GET: api/Categorias
        [HttpGet]
        public ICollection<Categoria> Get() => _servico.ListarTodos();

        // GET: api/Categorias/5
        [HttpGet("{id}", Name = "Get")]
        public Categoria Get(string id) => _servico.ObterPorId(id);

        // POST: api/Categorias
        [HttpPost]
        public void Post([FromBody]Categoria categoria) => _servico.Incluir(categoria);

        // PUT: api/Categorias/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Categoria categoria) => _servico.Atualizar(categoria);

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id, [FromBody]Categoria categoria) => _servico.Excluir(categoria);
    }
}
