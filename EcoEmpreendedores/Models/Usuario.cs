namespace EcoEmpreendedores.Models
{
    public class Usuario
    {
        public Usuario(string nome) 
        {
            Tipo = TipoUsuarioEnum.Usuario;
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }

        public Endereco Endereço { get; set;}

        public TipoUsuarioEnum Tipo { get; set; }
    }
}
