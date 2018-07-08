using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Services;

namespace DDD_MongDB.Application.Services
{
    public class AppCategoriaServico : AppServicoBase<Categoria>, IAppCategoriaServico
    {
        private readonly ICategoriaServico _servico;

        public AppCategoriaServico(ICategoriaServico servico) : base(servico) => _servico = servico;
    }
}
