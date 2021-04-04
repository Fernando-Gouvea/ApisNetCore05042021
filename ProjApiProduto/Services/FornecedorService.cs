using System.Collections.Generic;
using MongoDB.Driver;
using ProjApiProduto.Models;
using ProjApiProduto.Utils;

namespace ProjApiProduto.Services
{
     public class FornecedorService
    {
    private readonly IMongoCollection<Fornecedor> _fornecedor;

        public FornecedorService(IProdutoDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _fornecedor = database.GetCollection<Fornecedor>(settings.ProdutoCollectionName);
        }

        public List<Fornecedor> Get() =>
            _fornecedor.Find(fornecedor => true).ToList();

        public Fornecedor Get(string id) =>
            _fornecedor.Find<Fornecedor>(fornecedor => fornecedor.Id == id).FirstOrDefault();

        public Fornecedor Create(Fornecedor fornecedor)
        {
            _fornecedor.InsertOne(fornecedor);
            return fornecedor;
        }

        public void Update(string id, Fornecedor fornecedorIn) =>
            _fornecedor.ReplaceOne(fornecedor => fornecedor.Id == id, fornecedorIn);

        public void Remove(Fornecedor fornecedorIn) =>
            _fornecedor.DeleteOne(fornecedor => fornecedor.Id == fornecedorIn.Id);

        public void Remove(string id) => 
            _fornecedor.DeleteOne(fornecedor => fornecedor.Id == id);

    }
}