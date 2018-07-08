using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using DDD_MongDB.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DDD_MongDB.Domain.Services
{
    public class ServicoBase<T> : IServicoBase<T> where T : EntidadeBase
    {
        private readonly IRepositorioBase<T> _repositorio;

        public ServicoBase(IRepositorioBase<T> repositorio) => _repositorio = repositorio;

        public void Atualizar(T obj) => _repositorio.Atualizar(obj);

        public void Excluir(T obj) => _repositorio.Excluir(obj);

        public void Incluir(T obj) => _repositorio.Incluir(obj);

        public ICollection<T> ListarTodos() => _repositorio.ListarTodos();

        public T ObterPorId(string id) => _repositorio.ObterPorId(id);
    }
}
