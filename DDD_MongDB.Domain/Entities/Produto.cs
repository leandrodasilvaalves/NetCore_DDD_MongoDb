namespace DDD_MongDB.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        public Produto(string nome, decimal preco, string categoriaId)
        {
            Nome = nome;
            Preco = preco;
            CategoriaId = categoriaId;
        }

        public string  Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string CategoriaId { get; private set; }
    }
}
