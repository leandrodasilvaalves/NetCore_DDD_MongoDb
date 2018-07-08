using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace DDD_MongDB.Infra.Data.Repository
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public ProdutoRepositorio(IOptions<Configuracao> configuracoes, ICategoriaRepositorio categoriaRepositorio) 
            : base(configuracoes, CollectionName.Produtos) => 
            _categoriaRepositorio = categoriaRepositorio;


        public override void Incluir(Produto produto)
        {
            produto.Id = ObjectId.GenerateNewId().ToString();
            var categoria = _categoriaRepositorio.ObterPorId(produto.CategoriaId);
            categoria.Produtos.Add(produto);
            _categoriaRepositorio.Atualizar(categoria);
        }
    }
}
