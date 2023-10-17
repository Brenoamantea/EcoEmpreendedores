namespace EcoEmpreendedores.Models
{
    public class Endereco
    {
        public Endereco() 
        {
        }

        public int Id { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
    }
}
