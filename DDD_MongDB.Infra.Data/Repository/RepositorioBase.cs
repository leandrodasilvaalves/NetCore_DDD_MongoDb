using DDD_MongDB.Domain.Entities;
using DDD_MongDB.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD_MongDB.Infra.Data.Repository
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;

        public RepositorioBase(IOptions<Configuracao> configuracoes, string collectionName)
        {
            var client = new MongoClient(configuracoes.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(configuracoes.Value.DataBase);

            _collectionName = collectionName;
        }

        public IMongoCollection<TDocument> CollectionMongo<TDocument>(string collectionName) => _database.GetCollection<TDocument>(collectionName);

        //private void Save<TDocument>(string collectionName, TDocument document, Expression<Func<TDocument, bool>> filter) => 
        //    CollectionMongo<TDocument>(collectionName).ReplaceOne(filter, document, new UpdateOptions { IsUpsert = true });


        #region Metodos Interface

        public ICollection<T> ListarTodos() => CollectionMongo<T>(_collectionName).Find(x => true).ToList();

        public T ObterPorId(string id) => CollectionMongo<T>(_collectionName).Find(x => x.Id == id.Replace(@"^[\w]","")).FirstOrDefault();

        public virtual void Incluir(T obj)
        {
            obj.Id = ObjectId.GenerateNewId().ToString();
            obj.DataCadastro = DateTime.Now;
            CollectionMongo<T>(_collectionName).InsertOne(obj);
        }

        public void Atualizar(T obj) => CollectionMongo<T>(_collectionName).ReplaceOne(x => x.Id == obj.Id, obj);

        public void Excluir(T obj) => CollectionMongo<T>(_collectionName).DeleteOne(x => x.Id == obj.Id);

        #endregion
    }
}
