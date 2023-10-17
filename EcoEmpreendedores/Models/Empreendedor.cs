namespace EcoEmpreendedores.Models
{
    public class Empreendedor : Usuario
    {
        public Empreendedor(string nome) : base(nome)
        {
            Tipo = TipoUsuarioEnum.Empreendedor;
        }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }
    }
}
