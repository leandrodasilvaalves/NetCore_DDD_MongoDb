using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DDD_MongDB.Application.Services
{
    public class AppProdutoServico : AppServicoBase<Produto>, IAppProdutoServico
    {
        private readonly IProdutoServico _servico;

        public AppProdutoServico(IProdutoServico servico) : base(servico) => _servico = servico;
    }
}
