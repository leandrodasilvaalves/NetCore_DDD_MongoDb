using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Options;

namespace DDD_MongDB.Infra.Data.Repository
{
    public class CategoriaRepositorio : RepositorioBase<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(IOptions<Configuracao> configuracoes) : base(configuracoes, CollectionName.Categorias) { }
    }
}
