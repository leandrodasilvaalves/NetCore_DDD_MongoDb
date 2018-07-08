using DDD_MongDB.Application.Interfaces;
using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DDD_MongDB.Application.Services
{
    public class AppServicoBase<T> : IAppServicoBase<T> where T : EntidadeBase
    {
        private readonly IServicoBase<T> _servico;

        public AppServicoBase(IServicoBase<T> servico) => _servico = servico;

        public void Atualizar(T obj) => _servico.Atualizar(obj);

        public void Excluir(T obj) => _servico.Excluir(obj);

        public void Incluir(T obj) => _servico.Incluir(obj);

        public ICollection<T> ListarTodos() => _servico.ListarTodos();

        public T ObterPorId(string id) => _servico.ObterPorId(id);
    }
}
