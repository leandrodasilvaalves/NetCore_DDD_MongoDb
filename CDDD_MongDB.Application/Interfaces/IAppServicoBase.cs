using DDD_MongDB.Domain.Entities;
using System.Collections.Generic;

namespace DDD_MongDB.Application.Interfaces
{
    public interface IAppServicoBase<T> where T : EntidadeBase
    {
        T ObterPorId(string id);

        ICollection<T> ListarTodos();

        void Incluir(T obj);

        void Atualizar(T obj);

        void Excluir(T obj);
    }
}
