using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using DDD_MongDB.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DDD_MongDB.Domain.Services
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio) : base(produtoRepositorio) =>
            _produtoRepositorio = produtoRepositorio;
    }
}
