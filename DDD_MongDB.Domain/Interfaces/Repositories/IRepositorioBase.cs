using DDD_MongDB.Domain.Entities;
using System.Collections.Generic;

namespace DDD_MongDB.Domain.Interfaces.Repositories
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        T ObterPorId(string id);

        ICollection<T> ListarTodos();

        void Incluir(T obj);

        void Atualizar(T obj);

        void Excluir(T obj);
    }
}
