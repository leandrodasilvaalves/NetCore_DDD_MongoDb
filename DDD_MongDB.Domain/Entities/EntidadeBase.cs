using System;

namespace DDD_MongDB.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public string Id { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
