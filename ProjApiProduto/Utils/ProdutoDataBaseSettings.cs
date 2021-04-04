namespace ProjApiProduto.Utils
{
    public class ProdutoDataBaseSettings : IProdutoDataBaseSettings
    {
        public string ProdutoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}