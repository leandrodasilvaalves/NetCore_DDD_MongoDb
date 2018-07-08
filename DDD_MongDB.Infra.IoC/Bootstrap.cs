using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Application.Services;
using DDD_MongDB.Domain.Interfaces.Repositories;
using DDD_MongDB.Domain.Interfaces.Services;
using DDD_MongDB.Domain.Services;
using DDD_MongDB.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DDD_MongDB.Infra.IoC
{
    public static class Bootstrap
    {
        public static void Registrar(IServiceCollection services)
        {
            //Application layer
            services.AddTransient(typeof(IAppServicoBase<>), typeof(AppServicoBase<>));
            services.AddTransient<IAppCategoriaServico, AppCategoriaServico>();
            services.AddTransient<IAppProdutoServico, AppProdutoServico>();

            //Domain layer
            services.AddTransient(typeof(IServicoBase<>), typeof(ServicoBase<>));
            services.AddTransient<ICategoriaServico, CategoriaServico>();
            services.AddTransient<IProdutoServico, ProdutoServico>();

            //Infra.Data layer
            services.AddTransient(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
        }
    }
}
