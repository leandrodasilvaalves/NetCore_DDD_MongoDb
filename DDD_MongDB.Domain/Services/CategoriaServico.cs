using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using DDD_MongDB.Domain.Interfaces.Services;

namespace DDD_MongDB.Domain.Services
{
    public class CategoriaServico : ServicoBase<Categoria>, ICategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio) : base(categoriaRepositorio) =>
            _categoriaRepositorio = categoriaRepositorio;
    }
}
