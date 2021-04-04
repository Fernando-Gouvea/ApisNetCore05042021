namespace ProjApiCliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeMae { get; set; }
        public Endereco Endereco { get; set; }
    }
}