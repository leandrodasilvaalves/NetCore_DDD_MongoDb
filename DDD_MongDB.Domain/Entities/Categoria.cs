using System.Collections.Generic;

namespace DDD_MongDB.Domain.Entities
{
    public class Categoria : EntidadeBase
    {
        public Categoria(string nome, ICollection<Produto> produtos)
        {
            Nome = nome;
            Produtos = produtos;
        }

        public string Nome { get; private set; }
        public virtual ICollection<Produto> Produtos { get; private set; }
    }
}
