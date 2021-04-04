namespace ProjApiProduto.Utils
{
    public interface IProdutoDataBaseSettings
    {
        string ProdutoCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}