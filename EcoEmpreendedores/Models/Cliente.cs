namespace EcoEmpreendedores.Models
{
    public class Cliente : Usuario
    {
        public Cliente(string nome) : base(nome)
        {
            Tipo = TipoUsuarioEnum.Cliente;
        }

        public string CPF { get; set; }

        public string DataNascimento { get; set; }
    }
}
