using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjApiProduto.Models
{
    public class Fornecedor
    {
         [BsonId]    
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}